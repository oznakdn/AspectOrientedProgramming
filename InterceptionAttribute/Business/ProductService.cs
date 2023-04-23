using Entity.Entities;

namespace Business
{
    public class ProductService :IProductService
    {

        private static List<Product> products = new List<Product>
        {
            new Product (1,"A",100),
            new Product (2,"B",200),
            new Product (3,"C",300),
            new Product (4,"D",400),

        };

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.Name} is added.");
        }

        public List<Product >GetProduct()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id: {item.Id} Name: {item.Name} Price: {item.Price}");
            }
            return products.ToList();
        }
    }
}
