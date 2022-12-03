using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class MaterialDetailRepository : IMaterialDetailRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        
        public MaterialDetailRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(MaterialDetail obj)
        {
            if (obj == null)
            {
                return false;
            }
            obj.IdMDetail = Guid.NewGuid();
            _dbContext.MaterialDetails.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MaterialDetail obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.MaterialDetails.FirstOrDefault(x => x.IdMDetail == obj.IdMDetail);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MaterialDetail> GetAll()
        {
            return _dbContext.MaterialDetails.ToList();
        }

        public MaterialDetail GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.MaterialDetails.FirstOrDefault(c => c.IdMDetail == id);
        }
        public bool Update(MaterialDetail obj)
        {
        if (obj == null) return false;
        var temp = _dbContext.MaterialDetails.FirstOrDefault(x => x.IdMDetail == obj.IdMDetail);
        temp.Price = obj.Price;
        temp.ImportPrice = obj.ImportPrice;
        temp.Amount = obj.Amount;
        temp.Unit = obj.Unit;
        _dbContext.Update(temp);
        _dbContext.SaveChanges();
        return true;
    }
    }
}
