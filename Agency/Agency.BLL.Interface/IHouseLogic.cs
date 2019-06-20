using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IHouseLogic
    {
        void Add(House house);

        void DeleteById(int id);

        IEnumerable<House> GetAll();
    }
}
