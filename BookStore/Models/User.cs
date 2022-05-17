using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50), Required]
        public string FirstName { get; set; }

        [StringLength(50), Required]
        public string LastName { get; set; }

        [StringLength(20), Required]
        public string Login { get; set; }

        /*[NotMapped]
        public virtual string Password
        */
        [Required]
        public string PasswordHash { get; set; }

        public static string GetPasswordHash(string password)
        {
            MD5 mD5 = MD5.Create();
            var hash = mD5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }   

        [Required]
        public int Level { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders = new List<Order>();
        }
    }
}
