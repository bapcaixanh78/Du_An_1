using _1.DAL.Context;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ProducerRepository : IProducerRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public ProducerRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Models.Producer obj)
        {
            if (obj == null) return false;
            obj.IdProducer = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Models.Producer obj)
        {
            if (null == obj) return false;
            var tempobj = _dbContext.producers.FirstOrDefault(x => x.IdProducer == obj.IdProducer);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Models.Producer> GetAll()
        {
            return _dbContext.producers.ToList();
        }

        public Models.Producer GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.producers.FirstOrDefault(c => c.IdProducer == id);
        }

        public bool Update(Models.Producer obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.producers.FirstOrDefault(c => c.IdProducer == obj.IdProducer);
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
