using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int QuantityAll { get; set; }

        public int QuantityInOrders { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Publishing> Publishings { get; set; }

        public Book()
        {
            Authors = new List<Author>();
            Publishings = new List<Publishing>();
        }
    }
}
