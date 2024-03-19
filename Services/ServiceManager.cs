using Entities.Models;
using Services.Contracts;
using Repositories.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ServiceManager(IProductService productService,
        ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
           
        }

        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;

      
    }
}