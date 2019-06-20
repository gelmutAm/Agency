using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.DAL.Interface;
using Agency.DAL;
using Agency.BLL.Interface;
using Agency.BLL;

namespace Agency.Common
{
    public static class DependencyResolver
    {
        private static IAgentDao _agentDao;

        public static IAgentDao AgentDao => _agentDao ?? (_agentDao = new AgentDao());

        private static IAgentLogic _agentLogic;

        public static IAgentLogic AgentLogic => _agentLogic ?? (_agentLogic = new AgentLogic(AgentDao));



        private static IAreaDao _areaDao;

        public static IAreaDao AreaDao => _areaDao ?? (_areaDao = new AreaDao());

        private static IAreaLogic _areaLogic;

        public static IAreaLogic AreaLogic => _areaLogic ?? (_areaLogic = new AreaLogic(AreaDao));



        private static IBuyDao _buyDao;

        public static IBuyDao BuyDao => _buyDao ?? (_buyDao = new BuyDao());

        private static IBuyLogic _buyLogic;

        public static IBuyLogic BuyLogic => _buyLogic ?? (_buyLogic = new BuyLogic(BuyDao));



        private static ICityDao _cityDao;

        public static ICityDao CityDao => _cityDao ?? (_cityDao = new CityDao());

        private static ICityLogic _cityLogic;

        public static ICityLogic CityLogic => _cityLogic ?? (_cityLogic = new CityLogic(CityDao));



        private static IClientDao _clientDao;

        public static IClientDao ClientDao => _clientDao ?? (_clientDao = new ClientDao());

        private static IClientLogic _clientLogic;

        public static IClientLogic ClientLogic => _clientLogic ?? (_clientLogic = new ClientLogic(ClientDao));



        private static IHouseDao _houseDao;

        public static IHouseDao HouseDao => _houseDao ?? (_houseDao = new HouseDao());

        private static IHouseLogic _houseLogic;

        public static IHouseLogic HouseLogic => _houseLogic ?? (_houseLogic = new HouseLogic(HouseDao));



        private static IRentDao _rentDao;

        public static IRentDao RentDao => _rentDao ?? (_rentDao = new RentDao());

        private static IRentLogic _rentLogic;

        public static IRentLogic RentLogic => _rentLogic ?? (_rentLogic = new RentLogic(RentDao));



        private static IRentSaleDao _rentSaleDao;

        public static IRentSaleDao RentSaleDao => _rentSaleDao ?? (_rentSaleDao = new RentSaleDao());

        private static IRentSaleLogic _rentSaleLogic;

        public static IRentSaleLogic RentSaleLogic => _rentSaleLogic ?? (_rentSaleLogic = new RentSaleLogic(RentSaleDao));



        private static ISaleDao _saleDao;

        public static ISaleDao SaleDao => _saleDao ?? (_saleDao = new SaleDao());

        private static ISaleLogic _saleLogic;

        public static ISaleLogic SaleLogic => _saleLogic ?? (_saleLogic = new SaleLogic(SaleDao));



        private static IStreetDao _streetDao;

        public static IStreetDao StreetDao => _streetDao ?? (_streetDao = new StreetDao());

        private static IStreetLogic _streetLogic;

        public static IStreetLogic StreetLogic => _streetLogic ?? (_streetLogic = new StreetLogic(StreetDao));
    }
}
