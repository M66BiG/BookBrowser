namespace BookBrowser.Core
{
    internal class Engine
    {
        public static void Start()
        {
            
            var numero = Book.AddBook();
            
            Console.WriteLine(numero.Title + " " + numero.Description + " " + numero.Author + " " + numero.Year + " " + numero.Category);
            /*while (true)
            {

            }*/
        }
        public static void Stop() 
        {

        }
    }
}
