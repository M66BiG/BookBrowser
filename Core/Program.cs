namespace BookBrowser.Core
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Book> bookShelf = new()
            {
                new Book() { Title = "Beeck", Description = "Wie entstand Beeck", Author = "Melih aus Beeck", Year = 2022, Category = Genre.Misc },
                new Book() { Title = "Autohaus Mercedes", Description = "Wie der Standort in Essen gebaut wurde", Author = "Carl Benz", Year = 1998, Category = Genre.Action },
                new Book() { Title = "Duisburger Cafe - Zuständigkeiten ", Description = "Interne Geschichten", Author = "Ahmet", Year = 2005, Category = Genre.Romance },
                new Book() { Title = "Dinosaurier", Description = "Aussterben der Dinosaurier", Author = "Wissenschaftler XY", Year = 1899, Category = Genre.Thriller },
                new Book() { Title = "Baerl", Description = "Wie entstand Baerl", Author = "Melih aus Baerl", Year = 2023, Category = Genre.Misc },
                new Book() { Title = "Haus des Döners", Description = "Was es mit der Serie zu tun hat", Author = "Beecker Boy", Year = 2023, Category = Genre.Misc },
            };
            Engine.Start(bookShelf);
        }
    }
}