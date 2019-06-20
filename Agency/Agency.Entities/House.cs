using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class House
    {
        public House() { }

        public House(int id, string name)
        {
            this.IdHouse = id;
            this.Name = name;
        }

        public House(string name)
        {
            this.Name = name;
        }

        public House(List<object> fieldsValuesList)
        {
            this.IdHouse = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int IdHouse { get; set; }

        public string Name { get; set; }
    }
}
