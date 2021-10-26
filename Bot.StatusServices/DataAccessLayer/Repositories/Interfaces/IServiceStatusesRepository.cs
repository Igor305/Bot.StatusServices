using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IServiceStatusesRepository
    {
        public Task<List<ServiceStatus>> getStatuses();
    }
}
