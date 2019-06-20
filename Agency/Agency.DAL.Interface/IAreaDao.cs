﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Entities;

namespace Agency.DAL.Interface
{
    public interface IAreaDao
    {
        void Add(Area area);

        void DeleteById(int id);

        IEnumerable<Area> GetAll();
    }
}
