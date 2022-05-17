using BookStore.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddBookForm : Form 
    {
        public AddBookForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    cbAuthor.DataSource = context.Authors.Select(a => a.FirstName + " " + a.LastName).ToList();
                    cbPublishing.DataSource = context.Publishings.Select(p => p.PublishingName).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) &&
                !string.IsNullOrEmpty(txtCount.Text))
                this.DialogResult = DialogResult.OK;
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Заполните все ячейки!!!");
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm addAuthor = new AddAuthorForm();
            if (addAuthor.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        context.Authors.Add(new Models.Author
                        {
                            FirstName = addAuthor.txtFirstNameAuthor.Text,
                            LastName = addAuthor.txtLastNameAuthor.Text
                        });
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshData();
            }
        }

        private void btnAddPublishing_Click(object sender, EventArgs e)
        {
            AddPublishingForm addPublishing = new AddPublishingForm();
            if (addPublishing.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        context.Publishings.Add(new Models.Publishing
                        {
                            PublishingName = addPublishing.txtNamePublishing.Text
                        });
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
