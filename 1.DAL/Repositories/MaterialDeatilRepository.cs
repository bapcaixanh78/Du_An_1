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
    public class MaterialDeatilRepository : IMaterialDetailRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public MaterialDeatilRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(MaterialDetail material)
        {
            if(material == null) return false;
            _dbContext.MaterialDetails.Add(material);
            _dbContext.SaveChanges();
            return true;
            
        }

        public bool Delete(MaterialDetail material)
        {
            if (material == null) return false;
            _dbContext.MaterialDetails.Remove(material);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MaterialDetail> GetAll()
        {
            return _dbContext.MaterialDetails.ToList();
        }

        public bool Update(MaterialDetail material)
        {
            if (material == null) return false;
            _dbContext.MaterialDetails.Update(material);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
