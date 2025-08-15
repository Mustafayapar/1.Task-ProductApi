using _1.Task_ProductApi.BusinessLayer.Abstract;
using _1.Task_ProductApi.DataAccessLayer.Abstract;
using _1.Task_ProductApi.DTOs;
using _1.Task_ProductApi.EntityLayer.Concrete;

namespace _1.Task_ProductApi.BusinessLayer.Concrete
{
    
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> CreateProductAsync(CreateProductDto createProductDto)
        {
            var product = new Product
            {
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Stock = createProductDto.Stock,
                CreatedAtUtc = DateTime.UtcNow
            };

            var createdProduct = await _productRepository.AddAsync(product);
            return MapToDto(createdProduct);

        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null)
                throw new KeyNotFoundException($"Product with id {id} not found.");

            await _productRepository.DeleteAsync(product);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(MapToDto);
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            return product == null ? null : MapToDto(product);
        }

        private static ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                CreatedAtUtc = product.CreatedAtUtc
            };
        }
    }
}
