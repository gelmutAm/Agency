using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IBuyLogic
    {
        void Add(Buy buy);

        void DeleteById(int id);

        IEnumerable<Buy> GetAll();
    }
}
