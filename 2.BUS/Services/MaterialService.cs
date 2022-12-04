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
                return "Unsuccessful";
            }
            var VL = new Material()
            {
                IdMaterial = obj.IdMaterial,
                Code = obj.Code,
                Name = obj.Name,
                Status = obj.Status,
            };
            if (_ImaterialRepo.Add(VL)) return "Successful";
            return "Unsuccessful";
        }

        public string Delete(MaterialView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var VL = _ImaterialRepo.GetAll().FirstOrDefault(c => c.IdMaterial == obj.IdMaterial);
            VL.Status = 0;
            if (_ImaterialRepo.Update(VL)) return "Successful";
            return "Unsuccessful";
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

        public string Status(MaterialView obj)
        {
            if (obj == null) return "Unsuccessful";
            var material= _ImaterialRepo.GetAll().FirstOrDefault(c => c.IdMaterial == obj.IdMaterial);
            material.Status = 0;
            if (_ImaterialRepo.Status(material))
                return "Successful";
            return "Unsuccessful";
        }

        public string Update(MaterialView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var VL = _ImaterialRepo.GetAll().FirstOrDefault(c => c.IdMaterial == obj.IdMaterial);
            VL.IdMaterial = obj.IdMaterial;
            VL.Code = obj.Code;
            VL.Name = obj.Name;
            VL.Status = obj.Status;
            if (_ImaterialRepo.Update(VL)) return "Successful";
            return "Unsuccessful";
        }
    }
}
