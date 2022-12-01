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

        public ICollection<PointsFund> PFund { get; set; }

        public ICollection<PointWallet> PWallet { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
