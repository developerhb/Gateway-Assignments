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
    public class VehicleRepository : IVehicleRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Vehicle> GetVehicles()
        {
            return db.Vehicles;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            return db.SaveChanges() > 0;
        }
    }
}
