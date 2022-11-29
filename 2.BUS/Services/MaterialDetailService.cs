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
    public class MaterialDetailService : IMaterialDetailService
    {
        IMaterialDetailRepository _IMTRLDetailRepo;
        IMaterialRepository _IMTRLRepo;
        IProducerRepository _IProducerRepo;

        public MaterialDetailService()
        {
            _IMTRLDetailRepo = new MaterialDetailRepository();
            _IMTRLRepo = new MaterialRepository();
            _IProducerRepo = new ProducerRepository();
        }
        public string Add(MaterialDetailView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var MTRLDetail = new MaterialDetail()
            {
                IdMDetail = obj.IdMDetail,
                IdMaterial = obj.IdMaterial,
                IdProducer = obj.IdProducer,
                Price = obj.Price,
                ImportPrice = obj.ImportPrice,
                Amount = obj.Amount,
                Unit = obj.Unit,
            };
            if (_IMTRLDetailRepo.Add(MTRLDetail)) return "Successful";
            return "Unsuccessful";
        }

            public string Delete(MaterialDetailView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var MTRLDetail = new MaterialDetail()
            {
                IdMDetail = obj.IdMDetail,
                IdMaterial = obj.IdMaterial,
                IdProducer = obj.IdProducer,
                Price = obj.Price,
                ImportPrice = obj.ImportPrice,
                Amount = obj.Amount,
                Unit = obj.Unit,
            };
            if (_IMTRLDetailRepo.Delete(MTRLDetail)) return "Successful";
            return "Unsuccessful"; 
        }

        public List<MaterialDetailView> GetAll()
        {
            List<MaterialDetailView> list = new List<MaterialDetailView>();
            list = (from a in _IMTRLDetailRepo.GetAll().ToList()
                    join b in _IMTRLRepo.GetAll().ToList() on a.IdMaterial equals b.IdMaterial
                    join c in _IProducerRepo.GetAll().ToList() on a.IdProducer equals c.IdProducer
                    select new MaterialDetailView()
                    {
                        IdMaterial = a.IdMaterial,
                        IdMDetail = a.IdMDetail,
                        IdProducer = a.IdProducer,
                        NameMaterial = b.Name,
                        NameProducer = c.Name,
                        Price = a.Price,
                        ImportPrice = a.ImportPrice,
                        Amount = a.Amount,
                        Unit = a.Unit,
                    }).ToList();
            return list;
        }

        public string Update(MaterialDetailView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var MTRLDetail = new MaterialDetail()
            {
                IdMDetail = obj.IdMDetail,
                IdMaterial = obj.IdMaterial,
                IdProducer = obj.IdProducer,
                Price = obj.Price,
                ImportPrice = obj.ImportPrice,
                Amount = obj.Amount,
                Unit = obj.Unit,
            };
            if (_IMTRLDetailRepo.Update(MTRLDetail)) return "Successful";
            return "Unsuccessful";
        }
    }
}











