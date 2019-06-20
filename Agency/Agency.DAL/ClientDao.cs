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
    public class ClientDao : IClientDao
    {
        public void Add(Client client)
        {
            BaseDao.Add("AddClient", client);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteClient", id);
        }

        public IEnumerable<Client> GetAll()
        {
            return BaseDao.GetAll<Client>("Select * from Client");
        }
    }
}
