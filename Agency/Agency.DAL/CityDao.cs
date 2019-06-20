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
    public class CityDao : ICityDao
    {
        public void Add(City city)
        {
            BaseDao.Add("AddCity", city);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteCity", id);
        }

        public IEnumerable<City> GetAll()
        {
            return BaseDao.GetAll<City>("Select * from City");
        }
    }
}
