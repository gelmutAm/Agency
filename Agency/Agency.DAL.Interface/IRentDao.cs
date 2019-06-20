using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IRentDao
    {
        void Add(Rent rent);

        void DeleteById(int id);

        IEnumerable<Rent> GetAll();
    }
}
