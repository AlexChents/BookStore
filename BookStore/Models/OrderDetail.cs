using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CountBook { get; set; }

        [Required]
        public double Price { get; set; }

        //[ForeignKey("Order")]
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }

        //[ForeignKey("Book")]
        public int? BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
