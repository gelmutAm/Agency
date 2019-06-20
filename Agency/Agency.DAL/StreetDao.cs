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
    public class StreetDao : IStreetDao
    {
        public void Add(Street street)
        {
            BaseDao.Add("AddStreet", street);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteStreet", id);
        }

        public IEnumerable<Street> GetAll()
        {
            return BaseDao.GetAll<Street>("Select * from Street");
        }
    }
}
