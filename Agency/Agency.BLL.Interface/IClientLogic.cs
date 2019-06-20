using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IClientLogic
    {
        void Add(Client client);

        void DeleteById(int id);

        IEnumerable<Client> GetAll();
    }
}
