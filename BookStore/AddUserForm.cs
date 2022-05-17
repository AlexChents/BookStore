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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxFirstName.Text) &&
                !string.IsNullOrEmpty(txtBoxLastName.Text) &&
                !string.IsNullOrEmpty(txtBoxLogin.Text) &&
                !string.IsNullOrEmpty(txtBoxPassword.Text) &&
                !string.IsNullOrEmpty(txtBoxLevelAccess.Text))
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        var queryLogin = context.Users.Where(u => u.Login == txtBoxLogin.Text);
                        if (queryLogin.Count() == 0)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.None;
                            MessageBox.Show("Такой логин уже существует!!!");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Заполните все ячейки!!!");
            }
        }

        private void TxtBoxLevelAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
