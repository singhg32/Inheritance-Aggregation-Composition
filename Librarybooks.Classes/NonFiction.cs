using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    //Inheritance
    public class NonFiction : Book
    {
        public NonFiction(int pages, string title)
        {
            Pages = pages;
            Title = title;
            Genre = "Non Fiction";
        }

        public string GoToPage(int page)
        {
            _currentPage = page;
            return($"You are now on page {_currentPage}");
        }
    }
}
