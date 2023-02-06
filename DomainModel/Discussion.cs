namespace DomainModel
{
    public class Discussion
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }


        public Discussion(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
        public void removeDiscussion(Discussion discussion, List<Post> posts)
        {
            
        }
        public List<Discussion> getDiscussions()
        {
            return new List<Discussion>();
        }
        
    }
}