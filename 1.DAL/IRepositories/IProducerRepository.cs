using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IProducerRepository
    {
        bool Add(Producer obj);
        bool Update(Producer obj);
        bool Delete(Producer obj);
        Producer GetById(Guid id); //Tìm sp theo id
        List<Producer> GetAll();
    }
}
