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
    public class DealerRepository : IDealerRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Dealer> GetDealers()
        {
            return db.Dealers;
        }
    }
}
