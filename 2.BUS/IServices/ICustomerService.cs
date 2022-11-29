using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICustomerService
    {
        string Add(CustomerView obj);
        string Delete(CustomerView obj);
        string Update(CustomerView obj);
        List<CustomerView> GetAll();
    }
}
