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
    public class RentSaleLogic : IRentSaleLogic
    {
        private readonly IRentSaleDao _rentSaleDao;

        public RentSaleLogic(IRentSaleDao rentSaleDao)
        {
            this._rentSaleDao = rentSaleDao;
        }

        public void Add(RentSale rentSale)
        {
            this._rentSaleDao.Add(rentSale);
        }

        public void DeleteById(int id)
        {
            this._rentSaleDao.DeleteById(id);
        }

        public IEnumerable<RentSale> GetAll()
        {
            return _rentSaleDao.GetAll();
        }
    }
}
