namespace Dars2._2;

internal class Program
{
    static List<Book> Books = new List<Book>();
    static void Main(string[] args)
    {
        DataSeed();

        //var books = GetExpensiveBooksThenMinPrice(5);
        Console.WriteLine(GetTheMaxPageBook());



        //var book = GetMaxPricedBook();
        //Console.WriteLine(book.Price);

    }
    static List<Book> GetTwoTheMaxPageBook()
    {
        var book1 = new List<Book>();
        var book2 = new List<Book>();
        var book3 = Books;
        foreach (var b in book3)
        {
            
        }
    }

    static Book GetTheMaxPageBook()
    {
        var book = Books[0];
        foreach (var b in Books)
        {
            if(b.PageCount < book.PageCount)
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
