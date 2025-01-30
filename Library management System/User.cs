

namespace Library_management_System
{
    internal class User
    {   
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email) {
            Name = name;
            Email = email;
        }

        public virtual void ShowUserInfo()
        {
            Console.WriteLine($" user: {Name}, Email: {Email}");
        }
    }
}
