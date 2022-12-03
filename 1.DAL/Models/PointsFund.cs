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
<<<<<<< HEAD
        public Guid idHPoints { get; set; }

        public HistoryUsingPoints HPoints { get; set; }
=======
        public ICollection<HistoryUsingPoints> HPoints { get; set; }
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116
    }
}
