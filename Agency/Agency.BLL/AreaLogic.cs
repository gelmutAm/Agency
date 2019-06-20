using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;
using Agency.BLL.Interface;
using Agency.DAL;
using Agency.DAL.Interface;

namespace Agency.BLL
{
    public class AreaLogic : IAreaLogic
    {
        private readonly IAreaDao _areaDao;

        public AreaLogic(IAreaDao areaDao)
        {
            this._areaDao = areaDao;
        }

        public void Add(Area area)
        {
            this._areaDao.Add(area);
        }

        public void DeleteById(int id)
        {
            this._areaDao.DeleteById(id);
        }

        public IEnumerable<Area> GetAll()
        {
            return _areaDao.GetAll();
        }
    }
}
