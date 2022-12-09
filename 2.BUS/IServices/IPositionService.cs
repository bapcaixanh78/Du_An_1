using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IPositionService
    {
        string Add(PositionView obj);
        string Update(PositionView obj);
        string Delete(PositionView obj);
        string Status(PositionView obj);
        List<PositionView> GetAll();
        List<PositionView> Search(string input);

    }
}
