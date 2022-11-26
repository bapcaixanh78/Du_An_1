﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.Models
{
    public class Bill
    {
        [Key]
        public Guid IdBill { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime PaymentedDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int Status { get; set; }

        public int PointsUsed { get; set; }
        public virtual HistoryUsingPoints HPoints { get; set; }
        public Guid idHPoints { get; set; }
        public virtual Customer Customer { get; set; }
        public Guid IdCustomer { get; set; }
        public virtual Staff Staff { get; set; }
        public Guid IdStaff { get; set; }
        public virtual ICollection<BillDetail> BillDetails { get; set; }

    }
}
