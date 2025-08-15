using _1.Task_ProductApi.DataAccessLayer.Abstract;
using _1.Task_ProductApi.DataAccessLayer.Concrete;
using _1.Task_ProductApi.DataAccessLayer.Concrete.Repositories;
using _1.Task_ProductApi.EntityLayer.Concrete;

namespace _1.Task_ProductApi.DataAccessLayer.EntityFramework
{
    public class EfProductRepository:GenericRepository<Product>, IProductRepository
    {
        // This class inherits from GenericRepository<Product> and implements IProductDal.
        // It can contain additional methods specific to Product data access if needed.
        public EfProductRepository(Context context) : base(context)
        {
        }
    }
    
}
