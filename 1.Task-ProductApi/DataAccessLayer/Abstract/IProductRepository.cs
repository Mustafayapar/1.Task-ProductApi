using _1.Task_ProductApi.EntityLayer.Concrete;

namespace _1.Task_ProductApi.DataAccessLayer.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
        // Product için özel  sorgular yazılır
    }
}
