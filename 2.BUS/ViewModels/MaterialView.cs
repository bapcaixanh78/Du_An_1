using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class MaterialView
    {
        public Guid IdMaterial { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }
    }
}
