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
    public class HouseLogic : IHouseLogic
    {
        private readonly IHouseDao _houseDao;

        public HouseLogic(IHouseDao houseDao)
        {
            this._houseDao = houseDao;
        }

        public void Add(House house)
        {
            this._houseDao.Add(house);
        }

        public void DeleteById(int id)
        {
            this._houseDao.DeleteById(id);
        }

        public IEnumerable<House> GetAll()
        {
            return _houseDao.GetAll();
        }
    }
}
