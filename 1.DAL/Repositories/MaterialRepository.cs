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
    public class MaterialRepository : IMaterialRepository
    {
        private MaterialWarehouseDbContext _dbContext;

        public MaterialRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Material obj)
        {
            if (obj == null) return false;
            _dbContext.Materials.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Material obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.Materials.FirstOrDefault(x => x.IdMaterial == obj.IdMaterial);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Material> GetAll()
        {
            return _dbContext.Materials.ToList();
        }

        public Material GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Materials.FirstOrDefault(c => c.IdMaterial == id);
        }

        public bool Update(Material obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.Materials.FirstOrDefault(x => x.IdMaterial == obj.IdMaterial);
            temp.Code = obj.Code;
            temp.Name = obj.Name;
            temp.Status = obj.Status;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
