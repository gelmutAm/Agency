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
    public class ClientLogic : IClientLogic
    {
        private readonly IClientDao _clientDao;

        public ClientLogic(IClientDao clientDao)
        {
            this._clientDao = clientDao;
        }

        public void Add(Client client)
        {
            this._clientDao.Add(client);
        }

        public void DeleteById(int id)
        {
            this._clientDao.DeleteById(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientDao.GetAll();
        }
    }
}
