using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Buy
    {
        public Buy() { }

        public Buy(int id, int idSale, int idBuyer, int idAgent, DateTime date)
        {
            this.IdBuy = id;
            this.IdSale = idSale;
            this.IdBuyer = idBuyer;
            this.IdAgent = idAgent;
            this.Date = date;
        }

        public Buy(List<object> fieldsValuesList)
        {
            this.IdBuy = (int)fieldsValuesList[0];
            this.IdSale = (int)fieldsValuesList[1];
            this.IdBuyer = (int)fieldsValuesList[2];
            this.IdAgent = (int)fieldsValuesList[3];
            this.Date = (DateTime)fieldsValuesList[4];
        }

        public int IdBuy { get; set; }

        public int IdSale { get; set; }

        public int IdBuyer { get; set; }

        public int IdAgent { get; set; }

        public DateTime Date { get; set; }
    }
}
