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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int countNumbersPhone = 0;
            for (int i = 0; i < mTxtBoxPhone.Text.Length; i++)
            {
                if (mTxtBoxPhone.Text[i] >= '0' && mTxtBoxPhone.Text[i] <= '9')
                    countNumbersPhone++;
            }
            if (countNumbersPhone != 10)
                errorProvider.SetError(mTxtBoxPhone, "Вы ввели не все цифры");
            else
                errorProvider.Clear();

            if (errorProvider.GetError(txtBoxNameClient) == "" &&
                errorProvider.GetError(mTxtBoxPhone) == "")
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxNameClient_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNameClient.Text))
                errorProvider.SetError(txtBoxNameClient, "Не введено имя клиента!");
            else
                errorProvider.Clear();
        }
    }
}
