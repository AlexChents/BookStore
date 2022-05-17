using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateOrder { get; set; }

        public int CountBooks { get; set; }

        public double SumOrder { get; set; }

        public bool Payment { get; set; }

        public bool Shipped { get; set; }

        //[ForeignKey("Client")]
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }

        //[ForeignKey("User")]
        public int? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
