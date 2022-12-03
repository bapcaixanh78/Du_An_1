using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class BillDetailService : IBillDetailService
    {
        private IBillDetailRepository _billDetail;
        public BillDetailService()
        {
            _billDetail = new BillDetailRepository();
        }
        public string Add(BillDetail bill)
        {
            if (bill == null) return "Thêm thất bại";
            if (_billDetail.Add(bill)) return "Thêm thành công";
            return "Thêm thành công";
        }

        public string Delete(BillDetail bill)
        {
            if (bill == null) return "Xóa thất bại";
            var temp = _billDetail.GetAll().FirstOrDefault(c => c.IdMaterial == bill.IdMaterial);
            if (_billDetail.Delete(temp)) return "Xóa thành công";
            return "Xóa thành công";
        }

        public List<BillDetail> Get(string input)
        {
            throw new NotImplementedException();
        }

        public List<BillDetail> GetAll()
        {
            return _billDetail.GetAll();
        }

        public string Update(BillDetail bill)
        {
            if (bill == null) return "Thêm thất bại";
            var temp = _billDetail.GetAll().FirstOrDefault(c => c.IdMaterial == bill.IdMaterial);
            temp.MaterialName = bill.MaterialName;
            temp.Price = bill.Price;
            temp.Amount = bill.Amount;
            if (_billDetail.Update(temp)) return "Thêm thành công";
            return "Thêm thành công";
        }
    }
}
