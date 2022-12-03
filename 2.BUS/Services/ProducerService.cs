using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class ProducerService : IProducerService
    {
        IProducerRepository _iProducerRepository;
        public ProducerService()
        {
            _iProducerRepository = new ProducerRepository();
        }
        public string Add(ProducerView obj)
        {
            if (obj == null) return "Unsuccessful";
            var producer = new Producer()
            {
                IdProducer = obj.IdProducer,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
                Address = obj.Adress,
                City = obj.City,
                Nation = obj.Nation,
                Status = obj.Status,
            };
            if (_iProducerRepository.Add(producer)) return "Successful";
            return "Successful";
        }

        public string Delete(ProducerView obj)
        {
            if (obj == null) return "Unsuccessful";
            var producer = _iProducerRepository.GetAll().FirstOrDefault(c => c.IdProducer == obj.IdProducer);
            if (_iProducerRepository.Delete(producer))
                return "Successful";
            return "Unsuccessful";
        }

        public List<ProducerView> GetAll()
        {
            List<ProducerView> lstPrdViews = new List<ProducerView>();
            lstPrdViews = (
                from e in _iProducerRepository.GetAll().ToList()
                select new ProducerView()
                {
                    IdProducer = e.IdProducer,
                    Code = e.Code,
                    Name = e.Name,
                    PhoneNumber = e.PhoneNumber,
                    Adress = e.Address,
                    City = e.City,
                    Nation = e.Nation,
                    Status = e.Status,
                }).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều
            return lstPrdViews;
        }

        public string Update(ProducerView obj)
        {
            if (obj == null) return "Unsuccessful";
            var prd = _iProducerRepository.GetAll().FirstOrDefault(c => c.IdProducer == obj.IdProducer);
            prd.IdProducer = obj.IdProducer;
            prd.Code = obj.Code;
            prd.Name = obj.Name;
            prd.PhoneNumber = obj.PhoneNumber;
            prd.Address = obj.Adress;
            prd.City = obj.City;
            prd.Nation = obj.Nation;
            prd.Status = obj.Status;
            if (_iProducerRepository.Update(prd))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
