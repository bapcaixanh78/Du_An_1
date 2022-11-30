using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IBillDetailRepository
    {
        public bool Add(BillDetail bill);
        public bool Update(BillDetail bill);
        public bool Delete(BillDetail bill);
        public List<BillDetail> GetAll();
    }
}
