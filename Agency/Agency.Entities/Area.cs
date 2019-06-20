using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Area
    {
        public Area() { }

        public Area(int id, string name)
        {
            this.IdArea = id;
            this.Name = name;
        }

        public Area(string name)
        {
            this.Name = name;
        }

        public Area(List<object> fieldsValuesList)
        {
            this.IdArea = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int IdArea { get; set; }

        public string Name { get; set; }
    }
}
