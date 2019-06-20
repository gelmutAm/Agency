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
    public class RentDao : IRentDao
    {
        public void Add(Rent rent)
        {
            BaseDao.Add("AddRent", rent);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteRent", id);
        }

        public IEnumerable<Rent> GetAll()
        {
            return BaseDao.GetAll<Rent>("Select * from Rent");
        }
    }
}
