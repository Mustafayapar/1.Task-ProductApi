using _1.Task_ProductApi.DataAccessLayer.Abstract;
using _1.Task_ProductApi.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
namespace _1.Task_ProductApi.DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T product, CancellationToken ct = default)
        {
            await _context.Set<T>().AddAsync(product, ct);
            await _context.SaveChangesAsync(ct);
            return product;
        }

        public async Task DeleteAsync(T product, CancellationToken ct = default)
        {
            if (product != null)
            {
                _context.Set<T>().Remove(product);
                await _context.SaveChangesAsync(ct);
            }
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(CancellationToken ct = default)
        {
            return await _context.Set<T>().ToListAsync(ct);
        }

        public async Task<T?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await _context.Set<T>().FindAsync(new object[] { id }, ct);
        }
    }
}
