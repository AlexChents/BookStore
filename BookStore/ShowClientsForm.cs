using BookStore.BaseForm;
using BookStore.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class ShowClientsForm : BaseFormShow
    {
        public ShowClientsForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            DgvDataRefresh();
        }

        public override void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm.AddNewClient();
            DgvDataRefresh();
        }

        public override void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                int indexRowSelect = dgvData.CurrentCell.RowIndex;
                int idClientSelect = (int)dgvData[0, indexRowSelect].Value;
                AddClient addClient = new AddClient();
                addClient.txtBoxNameClient.Text = dgvData[1, indexRowSelect].Value.ToString();
                addClient.mTxtBoxPhone.Text = dgvData[2, indexRowSelect].Value.ToString();
                if (addClient.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            context.Clients.Find(idClientSelect).ClientName = addClient.txtBoxNameClient.Text;
                            context.Clients.Find(idClientSelect).Phone = addClient.mTxtBoxPhone.Text;
                            context.SaveChanges();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                DgvDataRefresh();
            }
        }

        public override void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                if (MessageBox.Show("Удалить клиента?", "Удаление клиента", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    int idClientSelect = (int)dgvData[0, dgvData.CurrentCell.RowIndex].Value;
                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            context.Clients.Remove(context.Clients.Find(idClientSelect));
                            context.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Удаление клиента невозможно!!! Т.к. по нему есть проведенные заказы, оплаты и отгрузки");
                    }
                    DgvDataRefresh();
                }
            }
        }

        private void DgvDataRefresh()
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    context.Clients.Load();
                    dgvData.DataSource = context.Clients.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
