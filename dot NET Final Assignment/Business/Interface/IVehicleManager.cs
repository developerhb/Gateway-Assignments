using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IVehicleManager
    {
        List<VehicleBusinessEntity> GetVehicles();

        bool AddVehicle(VehicleBusinessEntity businessEntity);

        bool DeleteVehicle(int ID);
    }
}
