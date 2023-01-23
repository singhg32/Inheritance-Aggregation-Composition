using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    //Inheritance
    public class SciFi : Fiction
    {
        public SciFi(int pages, string title) : base(pages, title) 
        {
            Genre = "Sci Fi";
        }


    }
    public class Fantasy : Fiction 
    {
        public Fantasy(int pages, string title) : base(pages, title)
        {
            Genre = "Fantasy";
        }
    }
    public class Mystery : Fiction 
    { 
        public Mystery(int pages, string title) : base(pages, title)
        {
            Genre = "Crime";
        }
    }


}
