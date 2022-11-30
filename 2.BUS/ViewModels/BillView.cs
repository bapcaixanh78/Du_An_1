using _1.DAL.Models;
using System;
using System.Collections.Generic;
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
        public decimal Price { get; set; }

        public string CustomerName { get; set; }
        public string CustomerNumberPhone { get; set; }
        public string StaffName { get; set; }
    }
}
