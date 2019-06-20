﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.BLL.Interface
{
    public interface IStreetLogic
    {
        void Add(Street street);

        void DeleteById(int id);

        IEnumerable<Street> GetAll();
    }
}
