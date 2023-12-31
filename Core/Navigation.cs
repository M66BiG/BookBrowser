﻿using BookBrowser.Shared;
using System.Reflection.Metadata.Ecma335;

namespace BookBrowser.Core
{
    internal class Navigation
    {
        public static List<Book> Navigator(List<Book> bookShelf)
        {
            Navigation n = new();
            n.NavigatorList();
            string tempString = Console.ReadLine();
            int tempNumb = Logic.CheckNumber(tempString);
            if (!Enum.IsDefined(typeof(Options), tempNumb))
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                Navigator(bookShelf);
            }
            
            return n.GetSelectedNavigation((Options)tempNumb, bookShelf);
        }

        private void NavigatorList() => Console.WriteLine($"1: {Options.List}\n2: {Options.Add}\n3: {Options.Delete}\n4: {Options.Sort}\n5: {Options.Filter}\n6: {Options.Quit}\n ");

        private List<Book> GetSelectedNavigation(Options option, List<Book> bookShelf)
        {
            switch (option)
            {
                case Options.List: Book.ShowList(bookShelf); break;
                case Options.Add: Book.AddBook(bookShelf); break;
                case Options.Delete: Book.DeleteBook(bookShelf); break;
                case Options.Sort: return Book.SortBookByAttribute(bookShelf);
                case Options.Filter: Book.SortBookByGenre(bookShelf); break;
                case Options.Quit: Engine.Stop(); break;
                default: Console.WriteLine("Wrong Input!"); break;
            }
            return bookShelf;
        }
    }
}
