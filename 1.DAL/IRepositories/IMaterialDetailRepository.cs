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
        public bool Add(MaterialDetail material);
        public bool Update(MaterialDetail material);
        public bool Delete(MaterialDetail material);
        public List<MaterialDetail> GetAll();
    }
}
