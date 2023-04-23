using Core.Aspects;
using Entity.Entities;

namespace Business
{
    public class ProductManager
    {
        private readonly IProductService _productService;

        public ProductManager()
        {
            _productService = new ProductService();
        }

        [LogInterceptorAspect(Primacy =1)]
        public virtual void AddProduct(Product product)
        {
            _productService.AddProduct(product);
        }
    }
}
