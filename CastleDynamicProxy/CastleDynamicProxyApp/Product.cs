namespace CastleDynamicProxyApp
{
    public class Product
    {
        public Product(){}
        public Product(string productName, decimal price):this()
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
