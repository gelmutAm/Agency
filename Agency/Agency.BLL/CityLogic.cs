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
    public class CityLogic : ICityLogic
    {
        private readonly ICityDao _cityDao;

        public CityLogic(ICityDao cityDao)
        {
            this._cityDao = cityDao;
        }

        public void Add(City city)
        {
            this._cityDao.Add(city);
        }

        public void DeleteById(int id)
        {
            this._cityDao.DeleteById(id);
        }

        public IEnumerable<City> GetAll()
        {
            return _cityDao.GetAll();
        }
    }
}
