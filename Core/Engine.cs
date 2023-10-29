namespace BookBrowser.Core
{
    internal class Engine
    {
        public static void Start()
        {
            //List<Book> bookShelf = Book.CreateBookShelf();
            List<Book> bookShelf = new();

            while (true)
            {
                Navigation.Navigator(bookShelf);
            }
        }
        public static void Stop() 
        {

        }
    }
}
