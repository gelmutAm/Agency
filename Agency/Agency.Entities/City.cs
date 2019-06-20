using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class City
    {
        public City() { }

        public City(int id, string name)
        {
            this.IdCity = id;
            this.Name = name;
        }

        public City(string name)
        {
            this.Name = name;
        }

        public City(List<object> fieldsValuesList)
        {
            this.IdCity = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int IdCity { get; set; }

        public string Name { get; set; }
    }
}
