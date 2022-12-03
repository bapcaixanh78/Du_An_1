using _1.DAL.Models;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IBillService
    {
        public string Add(Bill bill);
        public string Update(Bill bill);
        public List<BillView> GetAll();
        public List<Bill> GetFromData();
        public List<BillView> GetAll(string input);
        public string Delete(Bill bill);
    }
}
