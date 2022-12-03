using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class PointWallet
    {
        [Key]
        public Guid IdPWallet { get; set; }

        public int TotalScore { get; set; }

        public int PointsUsed { get; set; }

        public int PointsAdded { get; set; }

        public int Status { get; set; }
<<<<<<< HEAD
        public Guid IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public Guid idHPoints { get; set; }
        public HistoryUsingPoints HPoints { get; set; }
=======

        public Guid IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public ICollection<HistoryUsingPoints> HPoints { get; set; }
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116
    }
}
