using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EFRepositories
{
    public class ServiceStatusesRepository : IServiceStatusesRepository
    {
        private readonly Avrora37Context _avrora37Context;

        public ServiceStatusesRepository(Avrora37Context avrora37Context)
        {
            _avrora37Context = avrora37Context;
        }

        public async Task<List<ServiceStatus>> getStatuses()
        {
            List<ServiceStatus> serviceStatuses = await _avrora37Context.ServiceStatuses.ToListAsync();

            return serviceStatuses;
        }
    }
}
