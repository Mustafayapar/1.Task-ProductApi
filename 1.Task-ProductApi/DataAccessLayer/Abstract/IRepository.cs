using System.Linq.Expressions;

namespace _1.Task_ProductApi.DataAccessLayer.Abstract
{
    public interface IRepository<T> where T :class
    {
        Task<T?> GetByIdAsync(int id, CancellationToken ct = default);
        Task<IReadOnlyList<T>> GetAllAsync(CancellationToken ct = default);
        Task<T> AddAsync(T entity, CancellationToken ct = default);
        Task DeleteAsync(T entity, CancellationToken ct = default);
        
      
    }
}
