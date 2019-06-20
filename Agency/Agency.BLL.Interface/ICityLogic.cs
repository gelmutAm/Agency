using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface ICityLogic
    {
        void Add(City city);

        void DeleteById(int id);

        IEnumerable<City> GetAll();
    }
}
