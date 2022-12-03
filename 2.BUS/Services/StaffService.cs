﻿using _1.DAL.IRepositories;
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
        public StaffService()
        {
            _iStaffRepository = new StaffRepository();
        }
        public string Add(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = new Staff()
            {
                IdStaff = obj.IdStaff,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
<<<<<<< HEAD
                Address = obj.Adress,
                BirthOfDate = obj.DateOfBirth,
=======
                Address = obj.Address,
                BirthOfDate = obj.BirthOfDate,
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116
                Wage = obj.Wage,
                Status = obj.Status,
            };
            if (_iStaffRepository.Add(staff)) return "Successful";
            return "Successful";
        }

        public string Delete(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = _iStaffRepository.GetAll().FirstOrDefault(c => c.IdStaff == obj.IdStaff);
            if (_iStaffRepository.Delete(staff))
                return "Successful";
            return "Successful";
        }

        public List<StaffView> GetAll()
        {
            List<StaffView> lstStaffViews = new List<StaffView>();
            lstStaffViews = (
                from e in _iStaffRepository.GetAll().ToList()
                select new StaffView()
                {
                    IdStaff = e.IdStaff,
                    Code = e.Code,
                    Name = e.Name,
                    PhoneNumber = e.PhoneNumber,
<<<<<<< HEAD
                    Adress = e.Address,
                    DateOfBirth = e.BirthOfDate,
=======
                    Address = e.Address,
                    BirthOfDate = e.BirthOfDate,
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116
                    Wage = e.Wage,
                    Status = e.Status,
                }).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều
            return lstStaffViews;
        }

        public string Update(StaffView obj)
        {
            if (obj == null) return "Unsuccessful";
            var staff = _iStaffRepository.GetAll().FirstOrDefault(c => c.IdStaff == obj.IdStaff);
            staff.IdStaff = obj.IdStaff;
            staff.Code = obj.Code;
            staff.Name = obj.Name;
            staff.PhoneNumber = obj.PhoneNumber;
<<<<<<< HEAD
            staff.Address = obj.Adress;
            staff.BirthOfDate = obj.DateOfBirth;
=======
            staff.Address = obj.Address;
            staff.BirthOfDate = obj.BirthOfDate;
>>>>>>> 9deba97ab4328dbfc52139d80d82547d0dbbf116
            staff.Wage = obj.Wage;
            staff.Status = obj.Status;
            if (_iStaffRepository.Update(staff))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
