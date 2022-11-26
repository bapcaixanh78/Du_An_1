using _1.DAL.Context;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class WareHouseRepository : IWareHouseRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public WareHouseRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Models.WareHouse obj)
        {
            if (obj == null) return false;
            obj.IdWarehouse = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Models.WareHouse obj)
        {
            if (null == obj) return false;
            var tempobj = _dbContext.wareHouses.FirstOrDefault(x => x.IdWarehouse == obj.IdWarehouse);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Models.WareHouse> GetAll()
        {
            return _dbContext.wareHouses.ToList();
        }

        public Models.WareHouse GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.wareHouses.FirstOrDefault(c => c.IdWarehouse == id);
        }

        public bool Update(Models.WareHouse obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.wareHouses.FirstOrDefault(c => c.IdWarehouse == obj.IdWarehouse);
            temobj.Code = obj.Code;
            temobj.Name = obj.Name;
            temobj.PhoneNumber = obj.PhoneNumber;
            temobj.Adress = obj.Adress;
            temobj.City = obj.City;
            temobj.Nation = obj.Nation;
            temobj.Status = obj.Status;
            _dbContext.Update(temobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
