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
    public class StreetLogic : IStreetLogic
    {
        private readonly IStreetDao _streetDao;

        public StreetLogic(IStreetDao streetDao)
        {
            this._streetDao = streetDao;
        }

        public void Add(Street street)
        {
            this._streetDao.Add(street);
        }

        public void DeleteById(int id)
        {
            this._streetDao.DeleteById(id);
        }

        public IEnumerable<Street> GetAll()
        {
            return _streetDao.GetAll();
        }
    }
}
