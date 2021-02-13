using Data.Model;
using Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private DBContext db = new DBContext();

        public IQueryable<Service> GetServices()
        {
            return db.Services;
        }

        public bool AddService(Service service)
        {
            db.Services.Add(service);
            return db.SaveChanges() > 0;
        }

        public bool BookService(Service service)
        {
            service.IsActive = false;
            db.Entry(service).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }
    }
}
