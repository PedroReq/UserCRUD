
namespace WindowsFormsUsu
{
    public class Userr
    {
        // User class
        public int? Id { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public Userr(int? id, string username, string password, int age, string country)
        {
            Id = id;
            Username = username;
            Password = password;
            Age = age;
            Country = country;
        }
        

    }
}
