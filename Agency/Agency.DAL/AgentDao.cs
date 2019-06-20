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
    public class AgentDao : IAgentDao
    {
        public void Add(Agent agent)
        {
            BaseDao.Add("AddAgent", agent);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteAgent", id);
        }

        public IEnumerable<Agent> GetAll()
        {
            return BaseDao.GetAll<Agent>("Select * from Agent");
        }
    }
}
