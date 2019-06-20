using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IRentSaleDao
    {
        void Add(RentSale rentSale);

        void DeleteById(int id);

        IEnumerable<RentSale> GetAll();
    }
}
