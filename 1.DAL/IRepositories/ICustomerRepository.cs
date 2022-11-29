using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICustomerRepository
    {
        bool Add(Customer obj);

        bool Update(Customer obj);

        bool Delete(Customer obj);

        Customer GetById(Guid id);

        List<Customer> GetAll();
    }
}
