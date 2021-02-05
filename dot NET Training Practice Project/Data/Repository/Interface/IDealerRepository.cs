using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IDealerRepository
    {
        IQueryable<Dealer> GetDealers();

        bool AddDealer(Dealer dealer, Mechanic mechanic);
    }
}
