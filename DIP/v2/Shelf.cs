namespace DIP.v2
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
            if (product is DVD)
            {

                Console.WriteLine($"Put DVD on the shelf the DVD {product.Name}. Price is {product.Price}");
            }
            else
            {
                Console.WriteLine($"Put DVD on the shelf the book {product.Name}. Price is {product.Price}");
            }
            products.Add(product);
        }

        public decimal GetPrice()
        {
            decimal totalPrice = 0;

            foreach (IProduct product in products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }

        public decimal GetPriceForDvds()
        {
            decimal totalPrice = 0;

            foreach (IProduct product in products)
            {
                if (product is DVD)
                {
                    totalPrice += product.Price;
                }
            }

            return totalPrice;
        }

        public decimal GetPriceForBooks()
        {
            decimal totalPrice = 0;

            foreach (IProduct product in products)
            {
                if (product is Book)
                {
                    totalPrice += product.Price;
                }
            }

            return totalPrice;
        }
    }
}
