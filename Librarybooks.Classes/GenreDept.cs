using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    //Aggregation: The department is made up of books
    public abstract class GenreDept
    {
        private List<Book> _books = new();

        public int Numberofbooks
        {
            get { return Numberofbooks; }
            set { Books.Count(); }
        }
        public List<Book> Books { get; set; }
        public string Description()
        {
            return ($"This department has {Numberofbooks} books. Use DeptBooks to see these.");

        }
    }
}
