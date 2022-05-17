using BookStore.BaseForm;
using BookStore.Helpers;
using BookStore.Models;
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
    public partial class ShowBooksForm : BaseFormShow
    {
        public ShowBooksForm(int level)
        {
            InitializeComponent();
            InitData(level);
        }

        private void InitData(int level)
        {
            DgvDataRefresh();
            switch (level)
            {
                case 2:
                    this.AddToolStripMenuItem.Enabled = this.EditToolStripMenuItem.Enabled = 
                        this.DeleteToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    this.AddToolStripMenuItem.Enabled = this.EditToolStripMenuItem.Enabled =
                        this.DeleteToolStripMenuItem.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        public override void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm();
            if (addBook.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BookStoreContext context = new BookStoreContext())
                    {
                        Book book = new Book
                        {
                            Title = addBook.txtTitle.Text,
                            Price = Convert.ToDouble(addBook.txtPrice.Text),
                            QuantityAll = Convert.ToInt32(addBook.txtCount.Text),
                            QuantityInOrders = 0
                        };
                        Author author = context.Authors
                            .Where(a => a.FirstName + " " + a.LastName == addBook.cbAuthor.Text)
                            .Select(a => a).FirstOrDefault();
                        Publishing publishing = context.Publishings
                            .Where(p => p.PublishingName == addBook.cbPublishing.Text)
                            .Select(p => p).FirstOrDefault();
                        book.Authors.Add(author);
                        book.Publishings.Add(publishing);
                        context.Books.Add(book);
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

        public override void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                int indexRowSelect = dgvData.CurrentCell.RowIndex;
                int idBookSelect = (int)dgvData[0, indexRowSelect].Value;
                AddBookForm editBook = new AddBookForm
                {
                    Text = "Редактирование"
                };
                editBook.txtTitle.Text = dgvData["Название", indexRowSelect].Value.ToString();
                editBook.txtPrice.Text = dgvData["Цена", indexRowSelect].Value.ToString();
                editBook.txtCount.Text = dgvData["Все_количество", indexRowSelect].Value.ToString();
                editBook.cbAuthor.Text = dgvData["Автор", indexRowSelect].Value.ToString();
                editBook.cbPublishing.Text = dgvData["Издательство", indexRowSelect].Value.ToString();

                if (editBook.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            Book book = new Book
                            {
                                Title = editBook.txtTitle.Text,
                                Price = Convert.ToDouble(editBook.txtPrice.Text),
                                QuantityAll = Convert.ToInt32(editBook.txtCount.Text),
                                QuantityInOrders = 0
                            };
                            Author author = context.Authors
                                .Where(a => a.FirstName + " " + a.LastName == editBook.cbAuthor.Text)
                                .Select(a => a).FirstOrDefault();
                            Publishing publishing = context.Publishings
                                .Where(p => p.PublishingName == editBook.cbPublishing.Text)
                                .Select(p => p).FirstOrDefault();
                            book.Authors.Add(author);
                            book.Publishings.Add(publishing);
                            var edit = context.Books.Where(b => b.Id == idBookSelect).FirstOrDefault();
                            if (edit.Title != book.Title)
                                edit.Title = book.Title;
                            if(edit.Price != book.Price)
                                edit.Price = book.Price;
                            if(edit.QuantityAll != book.QuantityAll)
                                edit.QuantityAll = book.QuantityAll;
                            if(edit.Authors != book.Authors)
                                edit.Authors = book.Authors;
                            if (edit.Publishings != book.Publishings)
                                edit.Publishings = book.Publishings;
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }
                }
                DgvDataRefresh();
            }
        }

        public override void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvData.RowCount > 0)
            {
                if (MessageBox.Show("Удалить книгу?", "Удаление позиции", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int idBookSelect = (int)dgvData[0, dgvData.CurrentCell.RowIndex].Value;
                    try
                    {
                        using (BookStoreContext context = new BookStoreContext())
                        {
                            context.Books.Remove(context.Books.Find(idBookSelect));
                            context.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Книга не может быть удалена, т.к. она присутствует в заказах!!! Отмените все заказы на нее!!!");
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
                    dgvData.DataSource = context.Books
                        .Select(b => new
                        {
                            Ид = b.Id,
                            Название = b.Title,
                            Автор = b.Authors.Select(a => a.FirstName + " " + a.LastName).FirstOrDefault(),
                            Издательство = b.Publishings.Select(p => p.PublishingName).FirstOrDefault(),
                            Цена = Math.Round(b.Price, 2),
                            Все_количество = b.QuantityAll,
                            Количество_в_заказах = b.QuantityInOrders,
                            Свобдный_остаток = b.QuantityAll - b.QuantityInOrders
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
