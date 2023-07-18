namespace DIP.v3
{
    internal class Shelf
    {
        private List<IProduct> products;
        public Shelf()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public decimal GetPrice()
        {
            decimal price = 0;

            foreach (IProduct product in products)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
