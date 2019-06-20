using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface ICityDao
    {
        void Add(City city);

        void DeleteById(int id);

        IEnumerable<City> GetAll();
    }
}
