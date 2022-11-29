using _1.DAL.Models;
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
        string Add(MaterialDetailView obj);
        string Delete(MaterialDetailView obj);
        string Update(MaterialDetailView obj);
        List<MaterialDetailView> GetAll();
    }
}
