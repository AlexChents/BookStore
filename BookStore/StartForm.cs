using System;
using BookStore.Helpers;
using BookStore.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace BookStore
{
    public partial class StartForm : Form
    {
        public static string userOnLine;

        public StartForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext context = new BookStoreContext())
                {
                    var query = context.Users.Select(u => new { u.Login, u.PasswordHash, u.LastName, u.FirstName, u.Level});
                    bool isLoginFind = false;
                    foreach (var item in query)
                    {
                        if (item.Login == txtBoxLogin.Text)
                        {
                            userOnLine = item.Login;
                            isLoginFind = true;
                            if (item.PasswordHash == User.GetPasswordHash(txtBoxPassword.Text))
                            {
                                MainForm mainForm = new MainForm(item.Level);
                                mainForm.Show();
                                mainForm.Text += $" - пользователь - {item.LastName} {item.FirstName}";
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                            }
                            break;
                        }
                    }
                    if (!isLoginFind)
                        MessageBox.Show("Нет такого пользователя");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (BookStoreContext bookStoreContext = new BookStoreContext())
                {
                    if (!bookStoreContext.Database.Exists())
                    {
                        User user1 = new User
                        {
                            FirstName = "Admin",
                            LastName = "Admin",
                            Login = "admin",
                            Level = 1,
                            PasswordHash = User.GetPasswordHash("admin")
                        };
                        User user2 = new User
                        {
                            FirstName = "Генеральный",
                            LastName = "Директор",
                            Login = "GenDir",
                            Level = 1,
                            PasswordHash = User.GetPasswordHash("GenDir")
                        };
                        User user3 = new User
                        {
                            FirstName = "Менеджер",
                            LastName = "Первый",
                            Login = "FirstMen",
                            Level = 2,
                            PasswordHash = User.GetPasswordHash("FirstMen")
                        };
                        User user4 = new User
                        {
                            FirstName = "Менеджер",
                            LastName = "Второй",
                            Login = "SecondMen",
                            Level = 2,
                            PasswordHash = User.GetPasswordHash("SecondMen")
                        };
                        User user5 = new User
                        {
                            FirstName = "Главный",
                            LastName = "Бухгалтер",
                            Login = "GlavBuh",
                            Level = 3,
                            PasswordHash = User.GetPasswordHash("GlavBuh")
                        };
                        List<User> users = new List<User> { user1, user2, user3, user4, user5 };
                        bookStoreContext.Users.AddRange(users);
                        bookStoreContext.SaveChanges();

                        Author author1 = new Author { FirstName = "Азимов", LastName = "Айзек" };
                        Author author2 = new Author { FirstName = "Акунин", LastName = "Борис" };
                        Author author3 = new Author { FirstName = "Бравелли", LastName = "Джо" };
                        Author author4 = new Author { FirstName = "Гражне", LastName = "Жан" };
                        Author author5 = new Author { FirstName = "Дефо", LastName = "Даниель" };
                        Author author6 = new Author { FirstName = "Мартин", LastName = "Том" };
                        Author author7 = new Author { FirstName = "Миллер", LastName = "Энн" };
                        Author author8 = new Author { FirstName = "Стоун", LastName = "Шерон" };
                        List<Author> authors = new List<Author> { author1, author2, author3, author4, author5, author6, author7, author8 };
                        bookStoreContext.Authors.AddRange(authors);
                        bookStoreContext.SaveChanges();

                        Publishing publishing1 = new Publishing { PublishingName = "Vivat"};
                        Publishing publishing2 = new Publishing { PublishingName = "Ranok" };
                        Publishing publishing3 = new Publishing { PublishingName = "ACCA" };
                        List<Publishing> publishings = new List<Publishing> { publishing1, publishing2, publishing3 };
                        bookStoreContext.Publishings.AddRange(publishings);
                        bookStoreContext.SaveChanges();

                        Random random = new Random();

                        List<Book> books = new List<Book>();
                        for (int i = 0; i < 20; i++)
                        {
                            Book book = new Book
                            {
                                Title = $"Book{i + 1}",
                                Price = (i + 1) * 11.23,
                                QuantityAll = (i + 10) * 7,
                                QuantityInOrders = 0
                            };
                            book.Authors.Add(authors[random.Next(authors.Count)]);
                            book.Publishings.Add(publishings[random.Next(publishings.Count)]);
                            bookStoreContext.Books.Add(book);
                            books.Add(book);
                        }
                        bookStoreContext.SaveChanges();

                        List<Client> clients = new List<Client>();
                        for (int i = 0; i < 9; i++)
                        {
                            Client client = new Client
                            {
                                ClientName = $"Client{i + 1}",
                                Phone = $"067-{(i + 1) * 111}-{(i + 1) * 11}-{(i + 1) * 11}"
                            };
                            bookStoreContext.Clients.Add(client);
                            clients.Add(client);
                        }
                        bookStoreContext.SaveChanges();

                        for (int i = 0; i < 30; i++)
                        {
                            Order order = new Order
                            {
                                CountBooks = 0,
                                SumOrder = 0,
                                DateOrder = DateTime.Now,
                                Payment = false,
                                Shipped = false,
                                Client = clients[random.Next(clients.Count)],
                                User = users[random.Next(users.Count)]
                            };
                            bookStoreContext.Orders.Add(order);
                        
                            for (int j = 0; j < random.Next(1, 10); j++)
                            {
                                Book book = books[random.Next(books.Count)];
                                OrderDetail orderDetail = new OrderDetail
                                {
                                    Book = book,
                                    CountBook = random.Next(1, 5),
                                    Price = book.Price,
                                    Order = order
                                };
                                bookStoreContext.OrderDetails.Add(orderDetail);
                                order.SumOrder += orderDetail.CountBook * orderDetail.Price;
                                order.CountBooks += orderDetail.CountBook;
                                book.QuantityInOrders += orderDetail.CountBook;
                                //book.QuantityAll -= orderDetail.CountBook;
                            }
                        }
                        bookStoreContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
