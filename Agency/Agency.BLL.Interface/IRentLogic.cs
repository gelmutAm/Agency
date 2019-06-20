using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IRentLogic
    {
        void Add(Rent rent);

        void DeleteById(int id);

        IEnumerable<Rent> GetAll();
    }
}
