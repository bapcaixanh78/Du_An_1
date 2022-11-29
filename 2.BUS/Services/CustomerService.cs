using _1.DAL.IRepositories;
using _1.DAL.Models;
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
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _iCustomerRepo;
        
        public CustomerService()
        {
            _iCustomerRepo = new CustomerRepository();
        }
        public string Add(CustomerView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var KH = new Customer()
            {
                IdCustomer = obj.IdCustomer,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
                Adress = obj.Adress,
                BirthOfDate = obj.BirthOfDate,
                Status = obj.Status,
            };
            if (_iCustomerRepo.Add(KH)) return "Successful";
            return "Unsuccessful";
        }

        public string Delete(CustomerView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var KH = new Customer()
            {
                IdCustomer = obj.IdCustomer,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
                Adress = obj.Adress,
                BirthOfDate = obj.BirthOfDate,
                Status = obj.Status,
            };
            if (_iCustomerRepo.Delete(KH)) return "Successful";
            return "Unsuccessful";
        }

        public List<CustomerView> GetAll()
        {
            List<CustomerView> lstctm = new List<CustomerView>();
            lstctm = (from n in _iCustomerRepo.GetAll().ToList()
                      select new CustomerView
                      {
                          IdCustomer = n.IdCustomer,
                          Code = n.Code,
                          Name = n.Name,
                          PhoneNumber = n.PhoneNumber,
                          Adress = n.Adress,
                          BirthOfDate = n.BirthOfDate,
                          Status = n.Status,
                      }).ToList();
            return lstctm;
        }

        public string Update(CustomerView obj)
        {
            if (obj == null)
            {
                return "Unsuccessful";
            }
            var KH = new Customer()
            {
                IdCustomer = obj.IdCustomer,
                Code = obj.Code,
                Name = obj.Name,
                PhoneNumber = obj.PhoneNumber,
                Adress = obj.Adress,
                BirthOfDate = obj.BirthOfDate,
                Status = obj.Status,
            };
            if (_iCustomerRepo.Update(KH)) return "Successful";
            return "Unsuccessful";
        }
    }
}
