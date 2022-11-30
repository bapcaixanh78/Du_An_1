using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class BillService : IBillService
    {
        private IBillRepisitory _BillRepo;
        private IStaffRepository _StaffRepository;
        private IBillDetailRepository _billDetailRepo;
        public BillService()
        {
            _BillRepo = new BillRepository();
            _StaffRepository = new StaffRepository();
            _billDetailRepo = new BillDetailRepository();
        }
        public string Add(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Thêm thất bại";
            if (_BillRepo.Add(bill)) return "Thêm thành công";
            return "Thêm thành công";
        }

        public string Delete(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Xóa thất bại";
            var temp = _BillRepo.GetAll().FirstOrDefault(c => c.IdBill == bill.IdBill);
            if (_BillRepo.Delete(temp)) return "Xóa thành công";
            return "Xóa thành công";
        }

        public List<BillView> GetAll(string input)
        {
            throw new NotImplementedException();
        }

        public List<BillView> GetAll()
        {
            var list = (from a in _BillRepo.GetAll()
                        join b in _billDetailRepo.GetAll() on a.IdBill equals b.IdBill
                        join c in _StaffRepository.GetAll() on a.Staff.IdStaff equals c.IdStaff 
                        select new BillView
                        {
                            IdBill = a.IdBill,
                            Code = a.Code,
                            CreatedDate = a.CreatedDate,
                            PaymentedDate = a.PaymentedDate,
                            ShipDate = a.ShipDate,
                            ReceivedDate = a.ReceivedDate,
                            Status = a.Status,
                            Price = b.Price,
                            StaffName = c.Name,
                        }).ToList();
            return list;
        }

        public string Update(Bill bill)
        {
            if (string.IsNullOrEmpty(bill.Code)) return "Xóa thất bại";
            var temp = _BillRepo.GetAll().FirstOrDefault(c => c.IdBill == bill.IdBill);
            if (_BillRepo.Delete(temp)) return "Xóa thành công";
            return "Xóa thành công";
        }
    }
}
