namespace Librarybooks.Classes
{
    public abstract class Book
    {
        //fields
        protected int _pages;
        protected string _title;
        protected string _genre;
        protected bool _borrowed;
        protected int _currentPage;
        protected Page _titlePage;
        private Page[] _pages;

        //properties
        public int Pages { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int CurrentPage { get; set; }

        public Member Owner { get; set; }
        public virtual string Read(int page)
        {
            _currentPage += page;
            return ($"You have read {page} pages. You are on page {_currentPage}");
        }
        public bool CheckBorrowed()
        {
            return _borrowed;
        }
        public string Borrow(Member owner)
        {
            Owner = owner;
            _borrowed = true;
            return ($"Book has been borrowed by {owner}");
        }
        public string ReturnBook()
        {
            string message = $"Book has been returned by {Owner}";
            Owner = null;
            _borrowed = false;
            return message;
        }
        public string Description()
        {
            string message;

            if (_borrowed)
            {
                message = $"borrowed: the current owner is on page {_currentPage}.";
            }
            else
            {
                message = "not borrowed.";
            }
            return ($"This book is {Pages} pages long, titled {Title}. It is a {Genre} book and is {message}");
        }

    }
}