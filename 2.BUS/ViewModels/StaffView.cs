using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class StaffView
    {
        public Guid IdStaff { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Decimal Wage { get; set; }
        public int Status { get; set; }
    }
}
