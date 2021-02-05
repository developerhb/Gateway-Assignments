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

        public bool AddDealer(Dealer dealer, Mechanic mechanic)
        {
            db.Dealers.Add(dealer);
            List<Mechanic> mechanics = new List<Mechanic>();
            mechanics.Add(mechanic);
            dealer.Mechanics = mechanics;
            return db.SaveChanges()>0;
        }
    }
}
