using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IBillRepisitory
    {
        public bool Add(Bill bill);
        public bool Update(Bill bill);
        public bool Delete(Bill bill);
        public List<Bill> GetAll();
    }
}
