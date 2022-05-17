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
    public partial class AddPositionOrderDetailsForm : Form
    {
        public AddPositionOrderDetailsForm()
        {
            InitializeComponent();
        }

        private void txtBoxCountBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddPositionOrderDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    List<string> nameBooks = new List<string>();
                    nameBooks.AddRange(context.Books.Where(b => b.QuantityAll - b.QuantityInOrders > 0)
                        .Select(b => b.Title));
                    cbNameBook.DataSource = nameBooks;
                    txtBoxCountBookFree.Text = context.Books.Where(b => b.Title == cbNameBook.Text).
                        Select(b => b.QuantityAll - b.QuantityInOrders).FirstOrDefault().ToString();
                    txtBoxCountBook.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbNameBook_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    txtBoxCountBookFree.Text = context.Books.Where(b => b.Title == cbNameBook.Text).
                        Select(b => b.QuantityAll - b.QuantityInOrders).FirstOrDefault().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxCountBook_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxCountBook.Text))
            {
                if (Convert.ToInt32(txtBoxCountBook.Text) > Convert.ToInt32(txtBoxCountBookFree.Text))
                {
                    MessageBox.Show("Количество сбодного остатка меньше запрашиваемого");
                    txtBoxCountBook.Text = txtBoxCountBookFree.Text;
                }
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(txtBoxCountBook, "Введите количество");
            }
        }

        private void txtBoxCountBook_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxCountBook.Text) || Convert.ToInt32(txtBoxCountBook.Text) == 0)
            {
                errorProvider.SetError(txtBoxCountBook, "Введите количество");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void brnOk_Click(object sender, EventArgs e)
        {
            if (errorProvider.GetError(txtBoxCountBook) == "")
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
