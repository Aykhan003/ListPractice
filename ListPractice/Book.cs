namespace ListPractice
{
    internal class Book : BaseEntity
    {
        public Book(string name, string authorName, int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public string Name { get; set; } = null!;
        public string AuthorName { get; set; } = null!;
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } = false;
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, AuthorName: {AuthorName}, PageCount: {PageCount}, IsDeleted: {IsDeleted}");
        }
    }
}
