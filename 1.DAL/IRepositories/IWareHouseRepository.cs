using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IWareHouseRepository
    {
        bool Add(WareHouse obj);
        bool Update(WareHouse obj);
        bool Delete(WareHouse obj);
        WareHouse GetById(Guid id); //Tìm sp theo id
        List<WareHouse> GetAll();
    }
}
