using Data.Context;
using Data.Models;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class MechanicRepository : IMechanicRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Mechanic> GetMechanics()
        {
            return db.Mechanics;
        }
    }
}
