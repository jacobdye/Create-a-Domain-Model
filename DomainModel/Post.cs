
namespace DomainModel
{
    public class Post
    {
        private int id { get; set; }
        private string message { get; set; }
        private DateTime postedDate { get; set; }
        public Post(int id, string message, DateTime postedDate)
        {
            this.id = id;
            this.message = message;
            this.postedDate = postedDate;
        }
    

        public void removePost(Post post)
        {
            
        }
        public List<Post> getPosts()
        {
            return new List<Post>();
        }
    }
}