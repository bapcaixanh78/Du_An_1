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
    public class PositionService : IPositionService
    {
        IPositionRepository _iPositionRepository;
        public PositionService()
        {
            _iPositionRepository = new PositionRepository();
        }
        public string Add(PositionView obj)
        {
            if (obj == null) return "Unsuccessful";
            var position = new Position()
            {
                IdPosition = obj.IdPosition,
                Code = obj.Code,
                Name = obj.Name,
                Status = obj.Status,
            };
            if (_iPositionRepository.Add(position)) return "Successful";
            return "Successful";
        }

        public string Delete(PositionView obj)
        {
            if (obj == null) return "Unsuccessful";
            var position = _iPositionRepository.GetAll().FirstOrDefault(c => c.IdPosition == obj.IdPosition);
            if (_iPositionRepository.Delete(position))
                return "Successful";
            return "Unsuccessful";
        }

        public List<PositionView> GetAll()
        {
            List<PositionView> lstPstViews = new List<PositionView>();
            lstPstViews = (
                from e in _iPositionRepository.GetAll().ToList()
                select new PositionView()
                {
                    IdPosition = e.IdPosition,
                    Code = e.Code,
                    Name = e.Name,
                    Status = e.Status,
                }).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều
            return lstPstViews;
        }

        public string Update(PositionView obj)
        {
            if (obj == null) return "Unsuccessful";
            var pst = _iPositionRepository.GetAll().FirstOrDefault(c => c.IdPosition == obj.IdPosition);
            pst.IdPosition = obj.IdPosition;
            pst.Code = obj.Code;
            pst.Name = obj.Name;
            pst.Status = obj.Status;
            if (_iPositionRepository.Update(pst))
                return "Successful";
            return "Unsuccessful";
        }
    }
}
