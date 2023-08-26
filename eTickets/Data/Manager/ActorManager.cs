using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Manager
{
    public class ActorManager : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorManager(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
                _context.Actors.Remove(result);
               await _context.SaveChangesAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Actor> UpdateAsync(int id, Actor entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        async Task<IEnumerable<Actor>> IGenericService<Actor>.GetAll()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }
    }
}
