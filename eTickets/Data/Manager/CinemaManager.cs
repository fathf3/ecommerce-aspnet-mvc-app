using eTickets.Data.Base;
using eTickets.Data.Services;
using eTickets.Models;

namespace eTickets.Data.Manager
{
    public class CinemaManager : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemaManager(AppDbContext context) : base(context)
        {
        }
    }
}
