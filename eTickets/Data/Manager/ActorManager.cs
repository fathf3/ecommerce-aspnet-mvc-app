using eTickets.Data.Base;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Manager
{
    public class ActorManager : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorManager(AppDbContext context) : base(context) { }
    }
}
