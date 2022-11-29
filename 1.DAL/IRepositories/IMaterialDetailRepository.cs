using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMaterialDetailRepository
    {
        bool Add(MaterialDetail obj);

        bool Update(MaterialDetail obj);

        bool Delete(MaterialDetail obj);

        MaterialDetail GetById(Guid id);

        List<MaterialDetail> GetAll();
    }
}
   
