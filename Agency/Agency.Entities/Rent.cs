using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Rent
    {
        public Rent() { }

        public Rent(int id, int idRentSale, int idBuyer, int idAgent, DateTime date)
        {
            this.IdRent = id;
            this.IdRentSale = idRentSale;
            this.IdBuyer = idBuyer;
            this.IdAgent = idAgent;
            this.Date = date;
        }

        public Rent(List<object> fieldsValuesList)
        {
            this.IdRent = (int)fieldsValuesList[0];
            this.IdRentSale = (int)fieldsValuesList[1];
            this.IdBuyer = (int)fieldsValuesList[2];
            this.IdAgent = (int)fieldsValuesList[3];
            this.Date = (DateTime)fieldsValuesList[4];
        }

        public int IdRent { get; set; }

        public int IdRentSale { get; set; }

        public int IdBuyer { get; set; }

        public int IdAgent { get; set; }

        public DateTime Date { get; set; }
    }
}
