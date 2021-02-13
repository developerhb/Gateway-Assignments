using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IMechnicManager
    {
        List<MechanicBusinessEntity> GetMechanics();

        bool AddMechanic(MechanicBusinessEntity businessEntity);

        List<ServiceBusinessEntity> GetServices(MechanicBusinessEntity mechanic);
    }
}
