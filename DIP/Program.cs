//using DIP.v2;
using DIP.v3;

//HomeWork
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

book.Price = 10.00M;
shelf.AddProduct(book);

Console.WriteLine("\nTotal products price is " + shelf.GetPrice());


//HomeWork2.0
//DVD dvd = new DVD();
//Book book = new Book();
//Shelf shelf = new Shelf();

//dvd.Price = 2.00M;
//dvd.Name = "A";
//shelf.AddProduct(dvd);

//book.Price = 5.00M;
//book.Name = "AA";
//shelf.AddProduct(book);

//dvd.Price = 1.99M;
//dvd.Name = "B";
//shelf.AddProduct(dvd);

//book.Price = 4.99M;
//book.Name = "BB";
//shelf.AddProduct(book);

//dvd.Price = 2.99M;
//dvd.Name = "C";
//shelf.AddProduct(dvd);

//book.Price = 15.00M;
//book.Name = "CC";
//shelf.AddProduct(book);

//Console.WriteLine("\nTotal products price is " + shelf.GetPrice());
//Console.WriteLine("\nPrice for all DVDs is " + shelf.GetPriceForDvds());
//Console.WriteLine("\nPrice for all Books is " + shelf.GetPriceForBooks());


