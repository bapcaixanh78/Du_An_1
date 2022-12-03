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
    public class MaterialDetailService : IMaterialDetailService
    {
        private IMaterialRepository _material;
        private IMaterialDetailRepository _materialRepository;
        private IProducerRepository _producerRepository;
        private List<MaterialDetailView> _lstSp;
        public MaterialDetailService()
        {
            _material = new MaterialRepository();
            _materialRepository = new MaterialDeatilRepository();
            _producerRepository = new ProducerRepository();
            _lstSp = new List<MaterialDetailView>();
        }
        public string Add(MaterialDetailView material)
        {
            throw new NotImplementedException();
        }

        public string Delete(MaterialDetailView material)
        {
            throw new NotImplementedException();
        }

        public List<MaterialDetailView> GetAll()
        {
            _lstSp = (from a in _materialRepository.GetAll()
                        join b in _material.GetAll() on a.IdMaterial equals b.IdMaterial
                        join c in _producerRepository.GetAll() on a.IdProducer equals c.IdProducer
                        select new MaterialDetailView
                        {
                            IdMaterial = a.IdMaterial,
                            Status = b.Status,
                            Code = b.Code,
                            Name = b.Name,
                            IdMDetail = a.IdMDetail,
                            Price = a.Price,
                            Quanlity = a.Amount,
                            Producer = c.Name,
                            
                        }).ToList();
            return _lstSp;
        }

        public string Update(MaterialDetailView material)
        {
            throw new NotImplementedException();
        }
    }
}
