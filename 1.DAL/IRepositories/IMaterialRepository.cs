using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IMaterialRepository
    {
        bool Add(Material obj);

        bool Update(Material obj);

        bool Delete(Material obj);
        Material GetById(Guid id);
        List<Material> GetAll();
    }
}
