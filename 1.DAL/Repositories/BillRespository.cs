using _1.DAL.Context;
using _1.DAL.IRepositories;
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class BillRespository : IBillRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public BillRespository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public List<Bill> GetAll()
        {
            return _dbContext.bills.ToList();
        }

        public bool Update(Bill obj)
        {
            if (obj == null) return false;
            var temp = _dbContext.bills.FirstOrDefault(x => x.IdBill == obj.IdBill);
            temp.Status = obj.Status;
            _dbContext.Update(temp);
            _dbContext.SaveChanges();
            return true; 
        }
    }
}
