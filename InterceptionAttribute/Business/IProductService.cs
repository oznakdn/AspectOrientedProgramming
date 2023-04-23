using Entity.Entities;

namespace Business
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetProduct();
    }
}
