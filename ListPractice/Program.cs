using ListPractice;
using Utils;
#region
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Username: ");
//        string username = Console.ReadLine();

//        Console.Write("Email: ");
//        string email = Console.ReadLine();

//        Role role;

//        while (true)
//        {
//            Console.Write("Role (1-Admin, 2-Member): ");
//            string input = Console.ReadLine();

//            if (Enum.TryParse(input, out role) &&
//                (role == Role.Admin || role == Role.Member))
//            {
//                break;
//            }

//            Console.WriteLine("Invalid role. Please try again.");
//        }

//        User user = new User(username, email, role);

//        user.ShowInfo();
//    }
//}
#endregion
#region
Library library = new Library();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Add a book");
    Console.WriteLine("2. Get Book by ID");
    Console.WriteLine("3. Get all books");
    Console.WriteLine("4. Delete Book by ID");
    Console.WriteLine("5. Edit Book Name");
    Console.WriteLine("6. Filter by Page Count");
    Console.WriteLine("7. Exit");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();
    switch(choice)
    {
        case "1":
            Console.WriteLine("Book name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Author Name: ");
            string author = Console.ReadLine();
            Console.WriteLine("Book page count: ");
            int pageCount = Convert.ToInt32(Console.ReadLine());
            Book book = new Book(name, author, pageCount);
            library.AddBook(book);
            Console.WriteLine("Book added successfully.");
            break;
        case "2":
            Console.WriteLine("Book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Book foundBook = library.GetBookById(id);
            foundBook.ShowInfo();
            break;
        case "3":
            List<Book> allBooks = library.GetAllBooks();
            foreach (var b in allBooks)
            {
                b.ShowInfo();
            }
            break;
        case "4":
            Console.WriteLine("Book ID: ");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            library.DeleteBookById(deleteId);
            Console.WriteLine("Book deleted successfully.");
            break;
        case "5":
            Console.WriteLine("Book ID: ");
            int editId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("New Book Name: ");
            string newName = Console.ReadLine();
            library.EditBookName(editId, newName);
            Console.WriteLine("Book name updated successfully.");
            break;
        case "6":
            Console.WriteLine("Minimum Page Count: ");
            int minPageCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maximum Page Count: ");
            int maxPageCount = Convert.ToInt32(Console.ReadLine());
            library.FilterByPageCount(minPageCount, maxPageCount);
            break;
        case "7":
            Console.WriteLine("Exiting...");
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}
#endregion