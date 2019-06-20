using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IStreetDao
    {
        void Add(Street street);

        void DeleteById(int id);

        IEnumerable<Street> GetAll();
    }
}
