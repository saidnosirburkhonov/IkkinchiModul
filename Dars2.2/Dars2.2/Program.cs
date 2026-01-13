using Dars2._2.Models;
using Dars2._2.Services;

namespace Dars2._2;

internal class Program
{
    static List<Book> Books = new List<Book>();
    static void Main(string[] args)
    {
        Car car1 = new Car()
        {
            Model = "Lexus",
            Color = "DarkBlue",
            Price = 300000,
            FuelType = "Gasoline",
            RelaiseYear = DateTime.Now,
            IsNew = true
        };
        CarService carService = new CarService();
        carService.AddCar(car1);


        School school1 = new School()
        {
            Number = 144,
            Capacity = 1000,
            CurrentStudents = 880,
            Location = "Muqimiy street",
            IsFree = true,
            Language = "Uzbek"
        };
        SchoolService schoolService = new SchoolService();
        schoolService.AddSchool(school1);






        //DataSeed();

        //var books = GetExpensiveBooksThenMinPrice(5);
        //Console.WriteLine(GetTheMaxPageBook());
        //var book = GetMaxPricedBook();
        //Console.WriteLine(book.Price);

    }
    static List<Book> GetTwoTheMaxPageBook()
    {
        var firstbook = GetTheMaxPageBook();
        Book book = Books[0];
        foreach (var b in Books)
        {
            if (b.PageCount < book.PageCount && b.PageCount < book.PageCount)
            {
                book = b;
            }
        }
        return new List<Book> { firstbook, book };

    }

    static Book GetTheMaxPageBook()
    {
        var book = Books[0];
        foreach (var b in Books)
        {
            if (b.PageCount < book.PageCount)
            {
                book = b;
            }
        }
        return book;
    }

    static List<Book> GetExpensiveBooksThenMinPrice(decimal minPrice)
    {
        var expensiveBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.Price > minPrice)
            {
                expensiveBooks.Add(book);
            }
        }

        return expensiveBooks;
    }

    static Book GetMaxPricedBook()
    {
        Book book = Books[0];

        foreach (var b in Books)
        {
            if (book.Price < b.Price)
            {
                book = b;
            }
        }

        return book;
    }


    static void DataSeed()
    {
        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "The Great Gatsby",
            Author = "F. Scott Fitzgerald",
            Price = 10.99m,
            Description = "A novel set in the Jazz Age that tells the story of Jay Gatsby's unrequited love for Daisy Buchanan.",
            Created = DateTime.Now,
            Genre = "Classic",
            PageCount = 180
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Sariq Devni Minib",
            Author = "Xudoyberdi To'xtaboyev",
            Price = 5.99m,
            Description = "Legenda",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 270
        });

        Books.Add(new Book()
        {
            BookId = Guid.NewGuid(),
            Title = "Harry Poter",
            Author = "Opa",
            Price = 15.99m,
            Description = "Legenda 2",
            Created = DateTime.Now,
            Genre = "Fantasy",
            PageCount = 870
        });
    }
}
