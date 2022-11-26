using _1.DAL.Context;
using _1.DAL.IRepositories;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public PositionRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Models.Position obj)
        {
            if(obj == null) return false;
            obj.IdPosition = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Models.Position obj)
        {
            if(null == obj) return false;
            var tempobj = _dbContext.positions.FirstOrDefault(x => x.IdPosition == obj.IdPosition);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Models.Position> GetAll()
        {
            return _dbContext.positions.ToList();
        }

        public Models.Position GetById(Guid id)
        {
            if(id == Guid.Empty) return null;
            return _dbContext.positions.FirstOrDefault(c => c.IdPosition == id);
        }

        public bool Update(Models.Position obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.positions.FirstOrDefault(c => c.IdPosition == obj.IdPosition);
            temobj.Name = obj.Name;
            temobj.Status = obj.Status;
            _dbContext.Update(temobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
