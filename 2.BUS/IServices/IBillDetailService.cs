using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBillDetailService
    {
        public string Add(BillDetail bill);
        public string Update(BillDetail bill);
        public List<BillDetail> GetAll();
        public List<BillDetail> Get(string input);
        public string Delete(BillDetail bill);
    }
}
