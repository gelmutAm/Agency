using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IClientDao
    {
        void Add(Client client);

        void DeleteById(int id);

        IEnumerable<Client> GetAll();
    }
}
