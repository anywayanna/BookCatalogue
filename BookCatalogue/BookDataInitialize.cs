using BookCatalogue.Models;
using System.Linq;

namespace BookCatalogue
{
    public static class BookDataInitialize
    {
        public static void Initialize(BookContext context )
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Автостопом по галактике",
                        Author = "Дуглас Адамс",
                        Genre = Genres.Fiction,
                        PageCount = 544,
                        Price = 620
                    },
                    new Book
                    {
                        Title = "Чуб земли",
                        Author = "Макс Фрай",
                        Genre = Genres.Fiction,
                        PageCount = 320,
                        Price = 320
                    },
                    new Book
                    {
                        Title = "Игра Джи",
                        Author = "Антон Емельянов",
                        Genre = Genres.Fantasy,
                        PageCount = 384,
                        Price = 300
                    },
                    new Book
                    {
                        Title = "книга 1",
                        Author = "автор 1",
                        Genre = Genres.Comics,
                        PageCount = 100,
                        Price = 1
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
