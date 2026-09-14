using Utils;

namespace ListPractice
{
    internal class User : BaseEntity
    {
        public User(string userName, string email, Role role)
        {
            UserName = userName;
            Email = email;
            Role = role;
        }

        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Role Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, UserName: {UserName}, Email: {Email}, Role: {Role}");
        }
    }
}
