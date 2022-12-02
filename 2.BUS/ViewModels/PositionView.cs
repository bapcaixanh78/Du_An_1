using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class PositionView
    {
        public Guid IdPosition { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
