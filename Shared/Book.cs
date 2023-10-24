using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace BookBrowser.Shared
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Genre Category { get; set; }
        
        public Book AddBook () 
        {
            Notification n = new();
            Logic logic = new();

            Notification.ShowMessage(MessageType.SetBookTitle, null, null);
            string title = Console.ReadLine();
            Notification.ShowMessage(MessageType.SetBookDescription, null, null);
            string description = Console.ReadLine();
            Notification.ShowMessage(MessageType.SetBookAuthor, null, null);
            string author = Console.ReadLine();
            Notification.ShowMessage(MessageType.SetBookGenre, null, null);

            //Liste von Optionen anzeigen

            int tempNumb = logic.CheckNumber(Console.ReadLine());
            if (!Enum.IsDefined(typeof(Genre), tempNumb)) 
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                AddBook();
            }
            Genre category = (Genre)tempNumb;

            Book book = new() 
            { 
                Title = title,
                Description = description, 
                Author = author,
                Category = category
            };
            return this;
        }
    }
}
