//using BookStore.Models;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BookStore.Helpers
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext():base("connectBookStore")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Publishing> Publishings { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
