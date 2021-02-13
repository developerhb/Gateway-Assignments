using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IVehicleRepository
    {
        IQueryable<Vehicle> GetVehicles();

        bool AddVehicle(Vehicle vehicle);

        bool DeleteVehicle(int ID);
    }
}
