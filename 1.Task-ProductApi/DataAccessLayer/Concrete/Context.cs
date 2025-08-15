using _1.Task_ProductApi.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _1.Task_ProductApi.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }    
    }
}
