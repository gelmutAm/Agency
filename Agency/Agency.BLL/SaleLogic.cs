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
    public class SaleLogic : ISaleLogic
    {
        private readonly ISaleDao _saleDao;

        public SaleLogic(ISaleDao saleDao)
        {
            this._saleDao = saleDao;
        }

        public void Add(Sale sale)
        {
            this._saleDao.Add(sale);
        }

        public void DeleteById(int id)
        {
            this._saleDao.DeleteById(id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return _saleDao.GetAll();
        }
    }
}
