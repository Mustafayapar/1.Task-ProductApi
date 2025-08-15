using _1.Task_ProductApi.DTOs;

namespace _1.Task_ProductApi.BusinessLayer.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto);
        
        Task DeleteProductAsync(int id);
    }
}
