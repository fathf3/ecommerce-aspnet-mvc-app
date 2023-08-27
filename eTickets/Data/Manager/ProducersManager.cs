using eTickets.Data.Base;
using eTickets.Data.Services;
using eTickets.Models;

namespace eTickets.Data.Manager
{
    public class ProducersManager : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersManager(AppDbContext context) : base(context)
        {
        }
    }
}
