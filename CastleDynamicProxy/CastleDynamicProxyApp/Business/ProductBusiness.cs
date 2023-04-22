namespace CastleDynamicProxyApp.Business
{
    public class ProductBusiness
    {
        public virtual IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product("A",100),
                new Product("B",200),
                new Product("C",300),
                new Product("D",400),
                new Product("E",500)
            };

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1} - Product Name: {products[i].ProductName} Price: {products[i].Price}");
            }
            return products.ToList();
        }
    }
}
