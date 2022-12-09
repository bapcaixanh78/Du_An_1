using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBillServieve
    {
        string Update (BillView obj);
        List<BillView> GetAll();
        List<BillView> Search(DateTime  input);
    }
}
