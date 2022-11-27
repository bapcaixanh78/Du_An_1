using _1.DAL.Context;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private MaterialWarehouseDbContext _dbContext;
        public StaffRepository()
        {
            _dbContext = new MaterialWarehouseDbContext();
        }
        public bool Add(Models.Staff obj)
        {
            if (obj == null) return false;
            obj.IdStaff = Guid.NewGuid();
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Models.Staff obj)
        {
            if (null == obj) return false;
            var tempobj = _dbContext.staffs.FirstOrDefault(x => x.IdStaff == obj.IdStaff);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Models.Staff> GetAll()
        {
            return _dbContext.staffs.ToList();
        }

        public Models.Staff GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbContext.staffs.FirstOrDefault(c => c.IdStaff == id);
        }

        public bool Update(Models.Staff obj)
        {
            if (obj == null) return false;
            var temobj = _dbContext.staffs.FirstOrDefault(c => c.IdStaff == obj.IdStaff);
            temobj.Code = obj.Code;
            temobj.Name = obj.Name;
            temobj.PhoneNumber = obj.PhoneNumber;
            temobj.Adress = obj.Adress;
            temobj.DateOfBirth = obj.DateOfBirth;
            temobj.Wage = obj.Wage;
            temobj.Status = obj.Status;
            _dbContext.Update(temobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
