
namespace DomainModel
{
    public class User
    {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string role { get; set; }

        public User(int id, string name, string email, string password, string role)
        
        {
            this.id = id;
            this.name = name;;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public void removeUser(User user)
        {
            
        }
        public List<User> getUsers()
        {
            return new List<User>();
        }
    }
}