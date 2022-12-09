using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class BillView
    {
       
        public Guid IdBill { get; set; }     
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PaymentedDate { get; set; }
        public DateTime ShipDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int Status { get; set; }
        public int PointsUsed { get; set; }
        public string? Note { get; set; }
        public Guid IdCustomer { get; set; }      
        public Guid IdStaff { get; set; }
    }
}
