using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class MaterialDetailView
    {
        public Guid IdMaterial { get; set; }
        public Guid IdMDetail { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }
        public Decimal Price { get; set; }
        public int Quanlity { get; set; }
        public string Producer { get; set; }

    }
}
