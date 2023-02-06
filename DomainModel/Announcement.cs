
namespace DomainModel
{
    public class Announcement
    {
        private int id { get; set; }
        private string description { get; set; }
        private DateTime postedDate { get; set; }
        private string title { get; set; }
        public Announcement(int id, string description, DateTime postedDate, string title)
        {
            this.id = id;
            this.description = description;
            this.postedDate = postedDate;
            this.title = title;
        }
        public Announcement removeAnnouncement(Announcement announcement)
        {
            return announcement;
        }
        public List<Announcement> getAnnouncements()
        {
            return new List<Announcement>();
        }

    }
}