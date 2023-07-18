using DIP.v2;


DVD dvd = new DVD();
Book book = new Book();
Shelf shelf = new Shelf();

dvd.Price = 2.00M;
shelf.AddProduct(dvd);

book.Price = 5.00M;
shelf.AddProduct(book);

dvd.Price = 1.99M;
shelf.AddProduct(dvd);

book.Price = 4.99M;
shelf.AddProduct(book);

dvd.Price = 2.99M;
shelf.AddProduct(dvd);

book.Price = 15.00M;
shelf.AddProduct(book);

Console.WriteLine("Total products price is " + shelf.GetPrice());
Console.WriteLine("Price for all DVDs is " + shelf.GetPriceForDvds());
Console.WriteLine("Price for all Books is " + shelf.GetPriceForBooks());

