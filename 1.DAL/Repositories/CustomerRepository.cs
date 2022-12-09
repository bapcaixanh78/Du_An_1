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
    public class CustomerRepository : ICustomerRepository
    {
        private MaterialWarehouseDbContext _dbContext;

        public CustomerRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Customer obj)
        {
            if (obj == null) return false;
            obj.IdCustomer = Guid.NewGuid();
            _dbContext.Customers.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Customer obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.Customers.FirstOrDefault(x => x.IdCustomer == obj.IdCustomer);
            _dbContext.Remove(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Status(Customer obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.Customers.FirstOrDefault(c => c.IdCustomer == obj.IdCustomer);
            temp.Status = obj.Status;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Customer> GetAll()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.Customers.FirstOrDefault(c => c.IdCustomer == id);
        }

        public bool Update(Customer obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.Customers.FirstOrDefault(x => x.IdCustomer == obj.IdCustomer);
            temp.Code = obj.Code;
            temp.Name = obj.Name;
            temp.PhoneNumber = obj.PhoneNumber;
            temp.Address = obj.Address;
            temp.BirthOfDate = obj.BirthOfDate;
            temp.Status = obj.Status;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
