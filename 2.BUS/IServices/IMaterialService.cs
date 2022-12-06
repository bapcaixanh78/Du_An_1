using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMaterialService
    {
        string Add(MaterialView obj);
        string Delete(MaterialView obj);
        string Update(MaterialView obj);
        string Status(MaterialView obj);
        List<MaterialView> GetAll();
    }
}
