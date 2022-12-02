using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IProducerService
    {
        string Add(ProducerView obj);
        string Update(ProducerView obj);
        string Delete(ProducerView obj);
        List<ProducerView> GetAll();
    }
}
