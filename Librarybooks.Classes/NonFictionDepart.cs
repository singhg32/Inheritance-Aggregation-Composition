using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    
    public class NonFictionDepart : GenreDept
    {
        private List<NonFiction> _nonFictionBooks = new();

        public string DeptBooks()
        {
            return (string.Join("\n", _nonFictionBooks));
        }
    }
}
