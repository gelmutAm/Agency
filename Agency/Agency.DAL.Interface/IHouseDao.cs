using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IHouseDao
    {
        void Add(House house);

        void DeleteById(int id);

        IEnumerable<House> GetAll();
    }
}
