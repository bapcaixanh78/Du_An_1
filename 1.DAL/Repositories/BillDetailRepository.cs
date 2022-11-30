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
    public class BillDetailRepository : IBillDetailRepository
    {
        private MaterialWarehouseDbContext _DbContext;
        public BillDetailRepository()
        {
            _DbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(BillDetail bill)
        {
            if(bill == null) return false;
            _DbContext.billDetails.Add(bill);
            _DbContext.SaveChanges();
            return true;
        }

        public bool Delete(BillDetail bill)
        {
            if (bill == null) return false;
            _DbContext.billDetails.Remove(bill);
            _DbContext.SaveChanges();
            return true;
        }

        public List<BillDetail> GetAll()
        {
            return _DbContext.billDetails.ToList();
        }

        public bool Update(BillDetail bill)
        {
            if (bill == null) return false;
            _DbContext.billDetails.Add(bill);
            _DbContext.SaveChanges();
            return true;
        }
    }
}
