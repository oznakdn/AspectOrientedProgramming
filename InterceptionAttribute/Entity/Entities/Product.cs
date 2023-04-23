namespace Entity.Entities
{
    public class Product
    {

        private decimal _price;
        public Product(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price 
        {
            get=> _price;
            set => _price = _price < 0 ? 0 : value; 
        }
    }
}
