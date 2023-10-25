namespace BookBrowser.Shared
{
    public class Book : IBook
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public Genre Category { get; set; }
        
        public static Book AddBook () 
        {
            Logic logic = new();
            Notification.ShowMessage(MessageType.SetBookTitle, null, null);
            string? title = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookDescription, null, null);
            string? description = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookAuthor, null, null);
            string? author = Console.ReadLine();

            Notification.ShowMessage(MessageType.SetBookYear, null, null);
            int year = logic.CheckNumber(Console.ReadLine());

            Book book = new() 
            { 
                Title = title,
                Description = description, 
                Author = author,
                Year = year,
            };
            book.Category = book.GetCategory();
            return book;
        }

        private Genre GetCategory ()
        {
            Logic logic = new();
            Notification.ShowMessage(MessageType.SetBookGenre, null, null);

            //Liste von Optionen anzeigen
            //Liste von Optionen anzeigen
            //Liste von Optionen anzeigen
            
            string tempstring = Console.ReadLine();
            int tempNumb = logic.CheckNumber(tempstring);
            if (!Enum.IsDefined(typeof(Genre), tempNumb)) 
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                return GetCategory();
                
            }
            return (Genre)tempNumb;

        }
    }
}
