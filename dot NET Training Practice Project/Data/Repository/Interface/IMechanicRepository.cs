﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IMechanicRepository
    {
        IQueryable<Mechanic> GetMechanics();
    }
}
