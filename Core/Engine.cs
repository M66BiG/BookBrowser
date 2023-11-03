using BookBrowser.Enums;

namespace BookBrowser.Core
{
    internal class Engine
    {
        public static void Start()
        {
            List<Book> bookShelf = new();
            while (true)
            {
                Navigation.Navigator(bookShelf);
            }
        }
        public static void Stop() 
        {
            Environment.Exit(0);
        }
    }
}
