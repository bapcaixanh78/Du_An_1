using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IPositionRepository
    {
        bool Add(Position obj);
        bool Update(Position obj);
        bool Delete(Position obj);
        Position GetById(Guid id); //Tìm sp theo id
        List<Position> GetAll();
    }
}
