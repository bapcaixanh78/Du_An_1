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
    public class StaffService : IStaffService
    {
        IStaffRepository _iStaffRepository;
        IPositionRepository _iPositionRepositiry;
        IWareHouseRepository _iwareHouseRepository;
        public StaffService()
        {
            _iStaffRepository = new StaffRepository();
            _iPositionRepositiry = new PositionRepository();
            _iwareHouseRepository = new WareHouseRepository();
        }
        public string Add(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = new Staff()
            {
                IdPosition = obj.IdPosition,
                IdStaff = obj.IdStaff,
                IdWareHouse = obj.IdWareHouse,
                Code = obj.Code,
                Name = obj.Name,
                Gender = obj.Gender,
                PhoneNumber = obj.PhoneNumber,
                Address = obj.Address,
                BirthOfDate = obj.BirthOfDate,
                Wage = obj.Wage,
                Status = obj.Status,
            };
            if (_iStaffRepository.Add(staff)) return "Successful";
            return "Unsuccessful";
        }

        public string Delete(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = _iStaffRepository.GetAll().FirstOrDefault(c => c.IdStaff == obj.IdStaff);
            staff.Status = 0;
            if (_iStaffRepository.Update(staff))
                return "Successful";
            return "Unsuccessful";
        }

        public List<StaffView> GetAll()
        {
            List<StaffView> lstStaffViews = new List<StaffView>();
            lstStaffViews = (
                from e in _iStaffRepository.GetAll()
                join b in _iPositionRepositiry.GetAll() on e.IdPosition equals b.IdPosition
                join c in _iwareHouseRepository.GetAll() on e.IdWareHouse equals c.IdWarehouse
                select new StaffView()
                {
                    IdStaff = e.IdStaff,
                    IdPosition = e.IdPosition,
                    IdWareHouse = e.IdWareHouse,
                    Code = e.Code,
                    Name = e.Name,
                    Gender = e.Gender,
                    PhoneNumber = e.PhoneNumber,
                    Address = e.Address,
                    BirthOfDate = e.BirthOfDate,
                    Wage = e.Wage,
                    Status = e.Status,
                    NamePosition = b.Name,
                    NameWareHouse = c.Name,
                }).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều
            return lstStaffViews;
        }

        public List<StaffView> Search(string input)
        {
            return GetAll().Where(c => c.Code.ToLower().StartsWith(input.ToLower()) || c.Name.ToLower().StartsWith(input.ToLower())).ToList();
        }


        public string Update(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = _iStaffRepository.GetAll().FirstOrDefault(c => c.IdStaff == obj.IdStaff);
            staff.IdStaff = obj.IdStaff;
            staff.Code = obj.Code;
            staff.Name = obj.Name;
            staff.Gender = obj.Gender;
            staff.PhoneNumber = obj.PhoneNumber;
            staff.Address = obj.Address;
            staff.BirthOfDate = obj.BirthOfDate;
            staff.Wage = obj.Wage;
            staff.IdPosition = obj.IdPosition;
            staff.IdWareHouse = obj.IdWareHouse;
            staff.Status = obj.Status;
            if (_iStaffRepository.Update(staff))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
