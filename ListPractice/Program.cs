using ListPractice;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Role role;

        while (true)
        {
            Console.Write("Role (1-Admin, 2-Member): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, out role) &&
                (role == Role.Admin || role == Role.Member))
            {
                break;
            }

            Console.WriteLine("Invalid role. Please try again.");
        }

        User user = new User(username, email, role);

        user.ShowInfo();
    }
}