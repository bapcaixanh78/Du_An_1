using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IOrderService
    {
        public bool Add(OrderView order);
        public bool Update(OrderView order);
        public bool Delete(OrderView order);
    }
}
