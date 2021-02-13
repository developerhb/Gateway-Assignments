using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Interface
{
    public interface IServiceRepository
    {
        IQueryable<Service> GetServices();

        bool AddService(Service service);

        bool BookService(Service service);
    }
}
