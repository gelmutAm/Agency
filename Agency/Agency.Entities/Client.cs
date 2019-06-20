using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Client
    {
        public Client() { }

        public Client(int id, string fio, string phoneNumber)
        {
            this.IdClient = id;
            this.Fio = fio;
            this.PhoneNumber = phoneNumber;
        }

        public Client(string fio, string phoneNumber)
        {
            this.Fio = fio;
            this.PhoneNumber = phoneNumber;
        }

        public Client(List<object> fieldsValuesList)
        {
            this.IdClient = (int)fieldsValuesList[0];
            this.Fio = (string)fieldsValuesList[1];
            this.PhoneNumber = (string)fieldsValuesList[2];
        }

        public int IdClient { get; set; }

        public string Fio { get; set; }

        public string PhoneNumber { get; set; }
    }
}
