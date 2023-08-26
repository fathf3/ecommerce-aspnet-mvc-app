using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IGenericService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
