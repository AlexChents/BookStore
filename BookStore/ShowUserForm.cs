using BookStore.Helpers;
using BookStore.Models;
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
    public partial class ShowUserForm : BaseForm.BaseFormShow
    {
        public ShowUserForm()
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
                    dgvData.DataSource = context.Users
                        .Select(u => new
                        {
                            u.Id,
                            u.FirstName,
                            u.LastName,
                            u.Login,
                            u.Level
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            if (addUser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        context.Users.Add(new Models.User
                        {
                            FirstName = addUser.txtBoxFirstName.Text,
                            LastName = addUser.txtBoxLastName.Text,
                            Login = addUser.txtBoxLogin.Text,
                            Level = Convert.ToInt32(addUser.txtBoxLevelAccess.Text),
                            PasswordHash = User.GetPasswordHash(addUser.txtBoxPassword.Text)
                        });
                        context.SaveChanges();
                    }
                    RefreshData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public override void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount != 0)
            {
                AddUserForm editUser = new AddUserForm();
                editUser.txtBoxFirstName.Text = dgvData[1, dgvData.CurrentCell.RowIndex].Value.ToString();
                editUser.txtBoxLastName.Text = dgvData[2, dgvData.CurrentCell.RowIndex].Value.ToString();
                editUser.txtBoxLogin.Text = dgvData[3, dgvData.CurrentCell.RowIndex].Value.ToString();
                editUser.txtBoxLevelAccess.Text = dgvData[4, dgvData.CurrentCell.RowIndex].Value.ToString();
                if (editUser.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            var queryUser = context.Users.Where(u => u.Id == Convert.ToInt32(dgvData[0, dgvData.CurrentCell.RowIndex].Value))
                               .FirstOrDefault();
                            if (queryUser.LastName != editUser.txtBoxLastName.Text)
                                queryUser.LastName = editUser.txtBoxLastName.Text;
                            if (queryUser.FirstName != editUser.txtBoxFirstName.Text)
                                queryUser.FirstName = editUser.txtBoxFirstName.Text;
                            if (queryUser.Login != editUser.txtBoxLogin.Text)
                                queryUser.Login = editUser.txtBoxLogin.Text;
                            if (queryUser.Level != Convert.ToInt32(editUser.txtBoxLevelAccess.Text))
                                queryUser.Level = Convert.ToInt32(editUser.txtBoxLevelAccess.Text);
                            if (queryUser.PasswordHash != User.GetPasswordHash(editUser.txtBoxPassword.Text))
                                queryUser.PasswordHash = User.GetPasswordHash(editUser.txtBoxPassword.Text);
                            context.SaveChanges();
                        }
                        RefreshData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public override void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount != 0)
            {
                if (MessageBox.Show("Удалить пользователя?", "Удаление пользователя", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            context.Users.Remove(context.Users.Find((int)dgvData[0, dgvData.CurrentCell.RowIndex].Value));
                            context.SaveChanges();
                        }
                        RefreshData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Нельзя удалить пользователя, у которго есть уже проведенные документы в БД!!!");
                    }
                }
            }
        }
    }
}
