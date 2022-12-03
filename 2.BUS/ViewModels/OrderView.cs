using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class OrderView
    {
        public Guid IdSP { get; set; }
        public Guid IdMDetail { get; set; }
        public string MaSp { get; set; }
        public string ProductName { get; set; }
        public int Quanlity { get; set; }
        public decimal Price { get; set; }
    }
}
