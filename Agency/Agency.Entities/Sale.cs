using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Entities
{
    public class Sale
    {
        public Sale() { }

        public Sale(int id, int idClient, int idCity, int idArea, int idStreet, int idHouse, string houseType,
            int roomsNumber, int footage, int floorsNumber, decimal price)
        {
            this.IdSale = id;
            this.IdClient = idClient;
            this.IdCity = idCity;
            this.IdArea = idArea;
            this.IdStreet = idStreet;
            this.IdHouse = idHouse;
            this.HouseType = houseType;
            this.RoomsNumber = roomsNumber;
            this.Footage = footage;
            this.FloorsNumber = floorsNumber;
            this.Price = price;
        }

        public Sale(List<object> fieldsValuesList)
        {
            this.IdSale = (int)fieldsValuesList[0];
            this.IdClient = (int)fieldsValuesList[1];
            this.IdCity = (int)fieldsValuesList[2];
            this.IdArea = (int)fieldsValuesList[3];
            this.IdStreet = (int)fieldsValuesList[4];
            this.IdHouse = (int)fieldsValuesList[5];
            this.HouseType = (string)fieldsValuesList[6];
            this.RoomsNumber = (int)fieldsValuesList[7];
            this.Footage = (int)fieldsValuesList[8];
            this.FloorsNumber = (int)fieldsValuesList[9];
            this.Price = (decimal)fieldsValuesList[10];
        }

        public int IdSale { get; set; }

        public int IdClient { get; set; }

        public int IdCity { get; set; }

        public int IdArea { get; set; }

        public int IdStreet { get; set; }

        public int IdHouse { get; set; }

        public string HouseType { get; set; }

        public int RoomsNumber { get; set; }

        public int Footage { get; set; }

        public int FloorsNumber { get; set; }

        public decimal Price { get; set; }
    }
}
