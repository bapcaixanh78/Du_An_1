using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class PointsFund
    {
        [Key]
        public Guid IdPFund { get; set; }

        public Decimal PointsMoney { get; set; }

        public Decimal PointsUsed { get; set; }

        public int Status { get; set; }
        public ICollection<HistoryUsingPoints> HPoints { get; set; }
    }
}
