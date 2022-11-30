using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMaterialDetailService
    {
        public string Add(MaterialDetailView material);
        public string Update(MaterialDetailView material);
        public string Delete(MaterialDetailView material);
        public List<MaterialDetailView> GetAll();
    }
}
