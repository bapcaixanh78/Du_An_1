using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IStaffService
    {
        string Add(StaffView obj);
        string Update(StaffView obj);
        string Delete(StaffView obj);
        string Status(StaffView obj);
        List<StaffView> GetAll();
        List<StaffView> Search(string input);

    }
}
