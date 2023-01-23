using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    public abstract class Fiction : Book
    {
        public Fiction(int pages, string title)
        {
            Pages = pages;
            Title = title;
        }
    }
}
