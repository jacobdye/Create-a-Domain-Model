
namespace DomainModel
{
    public class Course
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }

        private string instructor { get; set; }

        private DateTime startDate { get; set; }
        private DateTime endDate { get; set; }

        public Course(int id, string name, string description,
            string instructor, DateTime startDate, DateTime endDate)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.instructor = instructor;
            this.startDate = startDate;
            this.endDate = endDate;
        }


        public void removeCourse(Course course)
        {
            
        }

        public void checkStudetAllowed(Enrollment enrollment)
        {
            
        }

        public List<Course> getCourses()
        {
            return new List<Course>();
        }
    }
}