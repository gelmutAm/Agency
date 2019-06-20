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
    public class SaleDao : ISaleDao
    {       
        public void Add(Sale sale)
        {
            BaseDao.Add("AddSale", sale);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteSale", id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return BaseDao.GetAll<Sale>("Select * from Sale");
        }
    }
}
