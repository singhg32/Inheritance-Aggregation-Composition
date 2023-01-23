using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarybooks.Classes
{
    // Association - Members are associated to books as a member borrows and returns books
    public class Member
    {
        //fields
        private int _id;
        private string _name;
        private int _age;

        //Properties
        public int ID { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Description()
        {
            return($"NAME: {Name} AGE: {Age} ID #{ID}");
        }

    }
}
