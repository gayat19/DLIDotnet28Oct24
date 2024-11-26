namespace FirstAPiApp.Models
{
    public enum Roles
    {
        Admin,PowerUser,User
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] HashKey { get; set; }
        public Roles Role { get; set; } = Roles.User;
        public User()
        {
            Username = string.Empty;
            Password = null;
            HashKey = null;
        }
        public Employee Employee { get; set; }
    }
}
