using _1.DAL.Models;
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

        public string Address { get; set; }

        public DateTime BirthOfDate { get; set; }

        public Decimal Wage { get; set; }
        public int Status { get; set; }

        public Guid IdPosition { get; set; }
        public Guid IdWareHouse { get; set; }
        public string NamePosition { get; set; }
        public string NameWareHouse { get; set; }
        public string Gender { get; set; }
    }
}
