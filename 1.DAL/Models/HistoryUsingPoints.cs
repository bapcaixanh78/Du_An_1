using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HistoryUsingPoints
    {
        [Key]
        public Guid idHPoints { get; set; }

        public int PointsUsed { get; set; }

        public DateTime DateUse { get; set; }

        public int PlusPoints { get; set; }

        public int Status { get; set; }

        public Guid IdPFund { get; set; }
        public PointsFund PFund { get; set; }
        public Guid IdPWallet { get; set; }
        public PointWallet PWallet { get; set; }
        public Guid IdBill { get; set; }
        public Bill Bills { get; set; }
    }
}
