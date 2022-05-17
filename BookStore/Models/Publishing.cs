using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Publishing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PublishingName { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Publishing()
        {
            Books = new List<Book>();
        }
    }
}
