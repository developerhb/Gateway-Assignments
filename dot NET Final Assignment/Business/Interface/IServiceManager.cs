using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IServiceManager
    {
        List<ServiceBusinessEntity> GetServices();

        bool AddService(ServiceBusinessEntity businessEntity);

        bool BookService(ServiceBusinessEntity businessEntity);
    }
}
