using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface ISaleDao
    {
        void Add(Sale sale);

        void DeleteById(int id);

        IEnumerable<Sale> GetAll();
    }
}
