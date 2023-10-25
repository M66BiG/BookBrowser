using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
