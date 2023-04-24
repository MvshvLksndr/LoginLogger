using System.Collections.Generic;
using System.Security.Policy;

namespace LoginLogger
{
    internal class MockUser
    {
        public List<User> Users = new List<User>()
        {
            new User("adm", "adm"),
            new User("Имя2", "1"),
            new User("Имя3", "1"),
            new User("Имя4", "1"),
        };
    }

    public class User
    {
        public string Login { get; internal set; }
        public string Password { get; internal set; }
        
        public User(string Lgn, string Pswrd)
        {
            Login = Lgn;
            Password = Pswrd;
        }
    }
}