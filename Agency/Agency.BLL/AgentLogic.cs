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
    public class AgentLogic : IAgentLogic
    {
        private readonly IAgentDao _agentDao;

        public AgentLogic(IAgentDao agentDao)
        {
            this._agentDao = agentDao;
        }

        public void Add(Agent agent)
        {
            this._agentDao.Add(agent);
        }

        public void DeleteById(int id)
        {
            this._agentDao.DeleteById(id);
        }

        public IEnumerable<Agent> GetAll()
        {
            return _agentDao.GetAll();
        }
    }
}
