namespace TestProject8.config
{
    public class User
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Defina usuários predefinidos
        public static User BD118 => new User("db118@cstng.com", "cst0962");
        public static User DB106 => new User("db106@cstng.com", "cst0962");
    }
}
