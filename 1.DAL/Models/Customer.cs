using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Customer
    {
        [Key]
        public Guid IdCustomer { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(30)]
        public string Address { get; set; }
        public string Gender { get; set; }

        public DateTime BirthOfDate { get; set; }

        public int Status { get; set; }
        public ICollection<PointWallet> PointWallets { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}
