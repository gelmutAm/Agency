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
    public class AreaDao : IAreaDao
    {
        public void Add(Area area)
        {
            BaseDao.Add("AddArea", area);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteArea", id);                
        }

        public IEnumerable<Area> GetAll()
        {
            return BaseDao.GetAll<Area>("Select * from Area");
        }
    }
}
