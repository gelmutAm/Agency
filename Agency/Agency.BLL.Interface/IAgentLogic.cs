using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IAgentLogic
    { 
        void Add(Agent agents);

        void DeleteById(int id);

        IEnumerable<Agent> GetAll();
    }
}
