using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IBuyDao
    {
        void Add(Buy buy);

        void DeleteById(int id);

        IEnumerable<Buy> GetAll();
    }
}
