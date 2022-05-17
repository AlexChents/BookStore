using System;
using BookStore.Helpers;
using BookStore.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace BookStore
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    context.Clients.Load();
                    cbClients.DataSource = context.Clients.Select(c => c.ClientName).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddNewClient();
        }

        public static void AddNewClient()
        {
            AddClient addClient = new AddClient();
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        string clientName = addClient.txtBoxNameClient.Text;
                        string phone = addClient.mTxtBoxPhone.Text;
                        context.Clients.Add(new Client
                        {
                            ClientName = clientName,
                            Phone = phone
                        });
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbClients.Text))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.None;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
