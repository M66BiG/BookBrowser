namespace BookBrowser.Interfaces
{
    public interface IBook
    {
        string Title { get; }
        string Description { get; }
        string Author { get; }
        int Year { get; }
        Genre Category { get; }
    }
}
