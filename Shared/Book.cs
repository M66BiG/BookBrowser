using System.Reflection.Metadata.Ecma335;

namespace BookBrowser.Shared
{
    public class Book : IBook
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public Genre Category { get; set; }

        public static void ShowList(List<Book> bookShelf)
        {
            foreach (Book book in bookShelf)
            {
                Console.WriteLine(book.Title);
            }
        }

        public static List<Book> AddBook(List<Book> bookShelf)
        {
            
            Notification.ShowMessage(MessageType.SetBookTitle, null, null);
            string? title = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookDescription, null, null);
            string? description = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookAuthor, null, null);
            string? author = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookYear, null, null);
            int year = Logic.CheckNumber(Console.ReadLine());

            Book book = new()
            {
                Title = title,
                Description = description,
                Author = author,
                Year = year,
            };
            book.Category = book.GetCategory();
            bookShelf.Add(book);
            return bookShelf;
        }
        private Genre GetCategory()
        {
            
            Notification.ShowMessage(MessageType.SetBookGenre, null, null);

            //Liste von Optionen anzeigen
            //Liste von Optionen anzeigen
            //Liste von Optionen anzeigen

            string tempString = Console.ReadLine();
            int tempNumb = Logic.CheckNumber(tempString);
            if (!Enum.IsDefined(typeof(Genre), tempNumb))
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                return GetCategory();

            }
            return (Genre)tempNumb;
        }
    }
}
