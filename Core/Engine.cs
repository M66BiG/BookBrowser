using BookBrowser.Enums;
using System.Net.WebSockets;

namespace BookBrowser.Core
{
    internal class Engine
    {
        public static void Start(List <Book> bookShelf)
        {
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
