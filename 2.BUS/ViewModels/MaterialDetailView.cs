using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class MaterialDetailView
    {
        public Guid IdMDetail { get; set; }
        public Guid IdMaterial { get; set; }
        public Guid IdProducer { get; set; }
        public Decimal Price { get; set; }
        public Decimal ImportPrice { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }

        public string NameMaterial { get; set; }
        public string NameProducer { get; set; }

    }
}
