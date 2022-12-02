using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IStaffRepository
    {
        bool Add(Staff obj);
        bool Update(Staff obj);
        bool Delete(Staff obj);
        Staff GetById(Guid id); //Tìm sp theo id
        List<Staff> GetAll();
    }
}
