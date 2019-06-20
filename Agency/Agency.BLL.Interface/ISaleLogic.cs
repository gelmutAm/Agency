using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface ISaleLogic
    {
        void Add(Sale sale);

        void DeleteById(int id);

        IEnumerable<Sale> GetAll();
    }
}
