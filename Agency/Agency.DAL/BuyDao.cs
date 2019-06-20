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
    public class BuyDao : IBuyDao
    {
        public void Add(Buy buy)
        {
            BaseDao.Add("AddBuy", buy);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteBuy", id);
        }

        public IEnumerable<Buy> GetAll()
        {
            return BaseDao.GetAll<Buy>("Select * from Buy");
        }
    }
}
