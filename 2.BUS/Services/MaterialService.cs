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
    public class MaterialService : IMaterialService
    {
        IMaterialRepository _ImaterialRepo;
        public MaterialService()
        {
            _ImaterialRepo = new MaterialRepository();
        }
        public string Add(MaterialView obj)
        {
            if (obj == null)
            {
                return "Thêm thất bại";
            }
            var VL = new Material()
            {
                IdMaterial = obj.IdMaterial,
                Code = obj.Code,
                Name = obj.Name,
                Status = obj.Status,
            };
            if (_ImaterialRepo.Add(VL)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(MaterialView obj)
        {
            if (obj == null)
            {
                return "Xóa thất bại";
            }
            var VL = new Material()
            {
                IdMaterial = obj.IdMaterial,
                Code = obj.Code,
                Name = obj.Name,
                Status = obj.Status,
            };
            if (_ImaterialRepo.Delete(VL)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<MaterialView> GetAll()
        {
            List<MaterialView> lstmtrl = new List<MaterialView>();
            lstmtrl = (from n in _ImaterialRepo.GetAll()
                       select new MaterialView
                       {
                           IdMaterial = n.IdMaterial,
                           Code = n.Code,
                           Name = n.Name,
                           Status = n.Status,
                       }).ToList();
            return lstmtrl;
        }

        public string Update(MaterialView obj)
        {
            if (obj == null)
            {
                return "Sửa thất bại";
            }
            var VL = new Material()
            {
                IdMaterial = obj.IdMaterial,
                Code = obj.Code,
                Name = obj.Name,
                Status = obj.Status,
            };
            if (_ImaterialRepo.Update(VL)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
