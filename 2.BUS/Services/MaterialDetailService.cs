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
        public MaterialDetailService()
        {
            _material = new MaterialRepository();
            _materialRepository = new MaterialDeatilRepository();
            _producerRepository = new ProducerRepository();
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
            var list = (from a in _material.GetAll()
                        join b in _materialRepository.GetAll() on a.IdMaterial equals b.Material.IdMaterial
                        join c in _producerRepository.GetAll() on b.Producer.IdProducer equals c.IdProducer
                        select new MaterialDetailView()
                        {
                            IdMaterial = b.IdMDetail,
                            IdMDetail = b.IdMDetail,
                            Code = a.Code,
                            Name = a.Name,
                            Status = a.Status,
                            Quanlity = b.Amount,
                            Price = b.Price,      
                            Producer = c.Name
                        }).ToList();
            return list;
        }

        public string Update(MaterialDetailView material)
        {
            throw new NotImplementedException();
        }
    }
}
