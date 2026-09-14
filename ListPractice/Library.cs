using System.Security.Cryptography.X509Certificates;

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
    }
}
