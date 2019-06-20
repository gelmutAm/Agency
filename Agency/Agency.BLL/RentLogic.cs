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
    public class RentLogic : IRentLogic
    {
        private readonly IRentDao _rentDao;

        public RentLogic(IRentDao rentDao)
        {
            this._rentDao = rentDao;
        }

        public void Add(Rent rent)
        {
            this._rentDao.Add(rent);
        }

        public void DeleteById(int id)
        {
            this._rentDao.DeleteById(id);
        }

        public IEnumerable<Rent> GetAll()
        {
            return _rentDao.GetAll();
        }
    }
}
