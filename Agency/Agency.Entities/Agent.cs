using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Agent
    {
        public Agent() { }

        public Agent(int id, string fio, string phoneNumber)
        {
            this.IdAgent = id;
            this.Fio = fio;
            this.PhoneNumber = phoneNumber;
        }

        public Agent(string fio, string phoneNumber)
        {
            this.Fio = fio;
            this.PhoneNumber = phoneNumber;
        }

        public Agent(List<object> fieldsValuesList)
        {
            this.IdAgent = (int)fieldsValuesList[0];
            this.Fio = (string)fieldsValuesList[1];
            this.PhoneNumber = (string)fieldsValuesList[2];
        }

        public int IdAgent { get; set; }

        public string Fio { get; set; }

        public string PhoneNumber { get; set; }
    }
}
