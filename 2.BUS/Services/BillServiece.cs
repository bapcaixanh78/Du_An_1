using _1.DAL.IRepositories;
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
    public class BillServiece : IBillServieve
    {
        IBillRepository _ibillRes;
        IStaffRepository _istaffRes;
        ICustomerRepository _icustomerRes;
        //private void fake()
        //{
        //    List<BillView> billViews= new List<BillView>();
        //    BillView view;
        //    view= new BillView() {"FA2B0FFA-FCE5-4F73-9139-99760F4E3798", "B01", "2022/10/01", "2022/11/01", "2022/11/10', '2020/11/20", 0,5,"" , "1AFA5AA2-6F45-4D3F-A371-1694E4C90955", "3B4DBE81-596B-469B-9FA9-08388AF7F71E"};
        //}
        public BillServiece()
        {
            _ibillRes= new BillRespository();
            _istaffRes = new StaffRepository();
            _icustomerRes= new CustomerRepository();
        }
        public List<BillView> GetAll()
        {
            List<BillView> lstbill = new List<BillView>();
            lstbill = (from a in _ibillRes.GetAll()
                       join b in _istaffRes.GetAll() on a.IdStaff equals b.IdStaff
                       join c in _icustomerRes.GetAll() on a.IdCustomer equals c.IdCustomer
                       select new BillView()
                       {
                           IdBill = a.IdBill,
                           IdCustomer = a.IdCustomer,
                           IdStaff= a.IdStaff,
                           Code= a.Code,
                           CreatedDate= a.CreatedDate,
                           PaymentedDate= a.PaymentedDate,
                           ShipDate= a.ShipDate,
                           ReceivedDate= a.ReceivedDate,
                           PointsUsed= a.PointsUsed,
                          Status = a.Status,
                          Note= a.Note,
                      }).ToList();
            return lstbill ;
        }

        public List<BillView> Search(DateTime input)
        {
            throw new NotImplementedException();
            //return GetAll().Where(c => c.ReceivedDate == input );

        }

        public string Update(BillView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var B = _ibillRes.GetAll().FirstOrDefault(c => c.IdBill == obj.IdBill);
            B.IdBill = obj.IdBill;
            B.IdCustomer = obj.IdCustomer;
            B.IdStaff = obj.IdStaff;
            B.Code = obj.Code;
            B.CreatedDate = obj.CreatedDate;
            B.PaymentedDate = obj.PaymentedDate;
            B.ShipDate= obj.ShipDate;
            B.ReceivedDate = obj.ReceivedDate;
            B.PointsUsed = obj.PointsUsed;
            B.Status = obj.Status;
            B.Note= obj.Note;
            
            if (_ibillRes.Update(B)) return "Successful";
            return "Unsuccessful";
        }
    }
}
