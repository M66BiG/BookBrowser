﻿using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

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
            int i = 1;
            bookShelf.ForEach(book =>
            {
                Console.WriteLine($"{i}: {book.Title} {book.Description} von: {book.Author} aus dem Jahr: {book.Year} ({book.Category})");
                i++;
            });
            Console.WriteLine();
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
            Console.WriteLine($"1: {Genre.Action}\n2: {Genre.Horror}\n3: {Genre.Thriller}\n4: {Genre.Romance}\n5: {Genre.SciFi}\n6: {Genre.Misc}");

            string tempString = Console.ReadLine();
            int tempNumb = Logic.CheckNumber(tempString);
            if (!Enum.IsDefined(typeof(Genre), tempNumb))
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                return GetCategory();

            }
            return (Genre)tempNumb;
        }
        public static List<Book> DeleteBook(List<Book> bookShelf)
        {
            ShowList(bookShelf);
            string tempString = Console.ReadLine();
            int tempNumb = Logic.CheckNumber(tempString);
            if (bookShelf.Count >= tempNumb - 1)
            {
                bookShelf.RemoveAt(tempNumb - 1);
            }
            else
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                DeleteBook(bookShelf);
            }
            return bookShelf;
        }

        public static List<Book> SortBookByAttribute(List<Book> bookShelf)
        {
            Notification.ShowMessage(MessageType.SelectSorting, null, null);
            Notification.ShowMessage(MessageType.ShowAttributes, null, null);
            string tempString = Console.ReadLine();
            int choice = Logic.CheckNumber(tempString);
            if (!Enum.IsDefined(typeof(Attributes), choice))
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                SortBookByAttribute(bookShelf);
            }
            return choice switch
            {
                1 => bookShelf.OrderBy(book => book.Author).ToList(),
                2 => bookShelf.OrderBy(book => book.Title).ToList(),
                3 => bookShelf.OrderBy(book => book.Year).ToList(),
                _ => bookShelf.ToList(),
            };
            //6 => bookShelf.Where(book => book.Category == Genre.Misc).ToList(),
        }
        public static void SortBookByGenre(List<Book> bookShelf)
        {
            Notification.ShowMessage(MessageType.SelectFilterGenre, null, null);
            Notification.ShowMessage(MessageType.ShowGenres, null, null);
            string tempString = Console.ReadLine();
            int choice = Logic.CheckNumber(tempString);
            if (!Enum.IsDefined(typeof(Genre), choice))
            {
                Notification.ShowMessage(MessageType.UnknownInput, null, null);
                SortBookByGenre(bookShelf);
            }
            List<Book> books = choice switch
            {
                1 => bookShelf.Where(book => book.Category == Genre.Action).ToList(),
                2 => bookShelf.Where(book => book.Category == Genre.Horror).ToList(),
                3 => bookShelf.Where(book => book.Category == Genre.Thriller).ToList(),
                4 => bookShelf.Where(book => book.Category == Genre.Romance).ToList(),
                5 => bookShelf.Where(book => book.Category == Genre.SciFi).ToList(),
                6 => bookShelf.Where(book => book.Category == Genre.Misc).ToList(),
                _ => bookShelf.ToList(),
            };
            ShowList(books);
        }
    }
}
