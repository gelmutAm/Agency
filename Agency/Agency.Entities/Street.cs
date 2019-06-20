using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Street
    {
        public Street() { }

        public Street(int id, string name)
        {
            this.IdStreet = id;
            this.Name = name;
        }

        public Street(string name)
        {
            this.Name = name;
        }

        public Street(List<object> fieldsValuesList)
        {
            this.IdStreet = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int IdStreet { get; set; }

        public string Name { get; set; }
    }
}
