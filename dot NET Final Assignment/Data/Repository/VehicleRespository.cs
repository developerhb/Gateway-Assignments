using Data.Model;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class VehicleRespository : IVehicleRepository
    {
        DBContext db = new DBContext();

        public IQueryable<Vehicle> GetVehicles()
        {
            return db.Vehicles;
        }

        public bool AddVehicle(Vehicle vehicle)
        {
            db.Vehicles.Add(vehicle);
            return db.SaveChanges() > 0;
        }

        public bool DeleteVehicle(int ID)
        {
            var vehicle = db.Vehicles.Find(ID);
            db.Vehicles.Remove(vehicle);
            return db.SaveChanges() > 0;
        }
    }
}
