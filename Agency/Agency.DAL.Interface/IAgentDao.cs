using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IAgentDao
    {
        void Add(Agent agents);

        void DeleteById(int id);

        IEnumerable<Agent> GetAll();
    }
}
