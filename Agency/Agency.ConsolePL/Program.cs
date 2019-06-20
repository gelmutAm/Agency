using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.BLL;
using Agency.Entities;
using Agency.DAL;
using Agency.DAL.Interface;

namespace Agency.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            AgentDao agentDao = new AgentDao();

            AgentLogic agentLogic = new AgentLogic(agentDao);

            Agent agent1 = new Agent(111, "khdkfhsk", "8908789796");

            agentLogic.Add(agent1);

            foreach(var agent in agentLogic.GetAll())
            {
                Console.WriteLine(agent.IdAgent + " " + agent.Fio + " " + agent.PhoneNumber);
            }

            agentLogic.Delete(111);

            Console.WriteLine("_____________________________________________");

            foreach (var agent in agentLogic.GetAll())
            {
                Console.WriteLine(agent.IdAgent + " " + agent.Fio + " " + agent.PhoneNumber);
            }
        }
    }
}
