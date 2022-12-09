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
    public class WareHouseService : IWareHouseService
    {
        IWareHouseRepository _iWHRepository;
        public WareHouseService()
        {
            _iWHRepository = new WareHouseRepository();
        }
        public string Add(WareHouseView obj)
        {
            if (obj == null) return "Unsuccessful";
            var wareHouse = new WareHouse()
            {
                IdWarehouse = obj.IdWarehouse,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
                Address = obj.Address,
                City = obj.City,
                Nation = obj.Nation,
                Status = obj.Status,
            };
            if (_iWHRepository.Add(wareHouse)) return "Successful";
            return "Unsuccessful";
        }

        public string Delete(WareHouseView obj)
        {
            if (obj == null) return "Unsuccessful";
            var warehouse = _iWHRepository.GetAll().FirstOrDefault(c => c.IdWarehouse == obj.IdWarehouse);
            warehouse.Status = 0;
            if (_iWHRepository.Update(warehouse))
                return "Successful";
            return "Unsuccessful";
        }

        public List<WareHouseView> GetAll()
        {
            List<WareHouseView> lstWareHouseViews = new List<WareHouseView>();
            lstWareHouseViews = (
                from e in _iWHRepository.GetAll().ToList()
                select new WareHouseView()
                {
                    IdWarehouse = e.IdWarehouse,
                    Code = e.Code,
                    Name = e.Name,
                    PhoneNumber = e.PhoneNumber,
                    Address = e.Address,
                    City = e.City,
                    Nation = e.Nation,
                    Status = e.Status,
                }).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều
            return lstWareHouseViews;
        }

        public List<WareHouseView> Search(string input)
        {

            return GetAll().Where(c => c.Code.ToLower().StartsWith(input.ToLower()) || c.Name.ToLower().StartsWith(input.ToLower())).ToList();
        }
            public string Update(WareHouseView obj)
        {
            if (obj == null) return "Unsuccessful";
            var wareHouse = _iWHRepository.GetAll().FirstOrDefault(c => c.IdWarehouse == obj.IdWarehouse);
            wareHouse.IdWarehouse = obj.IdWarehouse;
            wareHouse.Code = obj.Code;
            wareHouse.Name = obj.Name;
            wareHouse.PhoneNumber = obj.PhoneNumber;
            wareHouse.Address = obj.Address;
            wareHouse.City = obj.City;
            wareHouse.Nation = obj.Nation;
            wareHouse.Status = obj.Status;
            if (_iWHRepository.Update(wareHouse))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
