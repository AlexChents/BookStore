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
    public partial class AddAuthorForm : Form
    {
        public AddAuthorForm()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNameAuthor.Text) &&
                !string.IsNullOrEmpty(txtLastNameAuthor.Text))
                this.DialogResult = DialogResult.OK;
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Заполните все ячейки!!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
