namespace DomainModel
{
    public class Enrollment
    {
        private int id { get; set; }
        private DateTime enrollmentDate { get; set; }

        public Enrollment(int id, DateTime enrollmentDate)
        {
            this.id = id;
            this.enrollmentDate = enrollmentDate;
        }
    
        public void cancelEnrollment(User user, Course course)
        {
            
        }
        public List<Enrollment> getEnrollments() 
        {
            return new List<Enrollment>();
        }
    
    }
}