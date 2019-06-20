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
    public class BuyLogic : IBuyLogic
    {
        private readonly IBuyDao _buyDao;

        public BuyLogic(IBuyDao buyDao)
        {
            this._buyDao = buyDao;
        }

        public void Add(Buy buy)
        {
            this._buyDao.Add(buy);
        }

        public void DeleteById(int id)
        {
            this._buyDao.DeleteById(id);
        }

        public IEnumerable<Buy> GetAll()
        {
            return _buyDao.GetAll();
        }
    }
}
