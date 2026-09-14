using System.Security.Cryptography.X509Certificates;
using Utils;

namespace ListPractice
{
    internal class Library : BaseEntity
    {
        public int BookLimit { get; set; }
        private List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            foreach (var item in Books)
            {
                if (item.Name == book.Name && item.IsDeleted == false)
                {
                    throw new Utils.AlreadyExistsException("Book already exists");
                }
            }
            if (Books.Count >= BookLimit)
            {
                throw new Utils.CapacityLimitException("Book limit exceeded");
            }
            Books.Add(book);
        }
        public Book GetBookById(int? id)
        {
            var book = Books.Find(b => b.Id == id && b.IsDeleted == false);
            if (book == null)
            {
                throw new NullReferenceException("Book null");
            }
            return book;
        }
        public List<Book> GetAllBooks()
        {
            return Books.ToList();
        }
        public void DeleteBookById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id null");
            }
            var book = Books.Find(b => b.Id == id && b.IsDeleted == false);
            if (book == null)
            {
                throw new NotFoundException("Book null");
            }
            book.IsDeleted = true;
        }
        public void EditBookName(int? id, string newName)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id null");
            }
            var book = Books.Find(b => b.Id == id && b.IsDeleted == false);
            if (book == null)
            {
                throw new NotFoundException("Book null");
            }
            book.Name = newName;
        }
        public void FilterByPageCount(int minPageCount, int maxPageCount)
        {
            var filteredBooks = Books.Where(b => b.PageCount >= minPageCount && b.PageCount <= maxPageCount && b.IsDeleted == false).ToList();
            foreach (var book in filteredBooks)
            {
                Console.WriteLine($"Book ID: {book.Id}, Name: {book.Name}, Page Count: {book.PageCount}");
            }
        }
    }
}
