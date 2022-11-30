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
    public class BillRepository : IBillRepisitory
    {
        private MaterialWarehouseDbContext _DbContext;

        public BillRepository()
        {
            _DbContext = new MaterialWarehouseDbContext();
        }

        public bool Add(Bill bill)
        {
            if(bill == null) return false;
            _DbContext.bills.Add(bill);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(Bill bill)
        {
            if (bill == null) return false;
            _DbContext.bills.Remove(bill);
            _DbContext.SaveChanges();
            return true;
        }

        public List<Bill> GetAll()
        {
            return _DbContext.bills.ToList();
        }

        public bool Update(Bill bill)
        {
            if (bill == null) return false;
            _DbContext.bills.Update(bill);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
