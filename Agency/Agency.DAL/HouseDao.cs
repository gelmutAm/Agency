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
    public class HouseDao : IHouseDao
    {
        public void Add(House house)
        {
            BaseDao.Add("AddHouse", house);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteHouse", id);
        }

        public IEnumerable<House> GetAll()
        {
            return BaseDao.GetAll<House>("Select * from House");
        }
    }
}
