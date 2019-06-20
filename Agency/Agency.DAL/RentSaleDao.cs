using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Agency.Entities;
using Agency.DAL.Interface;

namespace Agency.DAL
{
    public class RentSaleDao : IRentSaleDao
    {       
        public void Add(RentSale rentSale)
        {
            BaseDao.Add("AddRentSale", rentSale);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteRentSale", id);
        }

        public IEnumerable<RentSale> GetAll()
        {
            return BaseDao.GetAll<RentSale>("Select * from RentSale");
        }
    }
}
