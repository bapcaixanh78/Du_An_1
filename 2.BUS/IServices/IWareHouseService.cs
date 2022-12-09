using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IWareHouseService
    {
        string Add(WareHouseView obj);
        string Update(WareHouseView obj);
        string Delete(WareHouseView obj);
        string Status(WareHouseView obj);
        List<WareHouseView> Search(string input);
        List<WareHouseView> GetAll();
    }
}
