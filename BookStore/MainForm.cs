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
    public partial class MainForm : Form
    {
        private int accessLevel;

        public MainForm(int level)
        {
            InitializeComponent();
            InitLevel(level);
        }

        private void InitLevel(int level)
        {
            accessLevel = level;
            switch (level)
            {
                case 2:
                    this.managersToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    this.managersToolStripMenuItem.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Книжный магазин. Ченцов А.А.");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(accessLevel)
            {
                MdiParent = this,
                Size = this.Size
            };
            ordersForm.Show();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClientsForm showClients = new ShowClientsForm
            {
                MdiParent = this,
                Size = this.Size
            };
            showClients.Show();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBooksForm showBooks = new ShowBooksForm(accessLevel)
            {
                MdiParent = this,
                Size = this.Size
            };
            showBooks.Show();
        }

        private void ManagersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserForm showUser = new ShowUserForm
            {
                MdiParent = this,
                Size = this.Size
            };
            showUser.Show();
        }
    }
}
