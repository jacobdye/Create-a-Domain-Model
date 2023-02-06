
namespace DomainModel
{
    public class Submission
    {
        private int id { get; set; }
        private DateTime submissionDate { get; set; }
        private Byte[] fileData { get; set; }
        private double grade { get; set; }
        private string comments { get; set; }

        public Submission(int id, DateTime submissionDate, Byte[] fileData, double grade, string comments)
        {
            this.id = id;
            this.submissionDate = submissionDate;
            this.fileData = fileData;
            this.grade = grade;
            this.comments = comments;
        }

        public Byte[] readFile(Byte file)
        {
            return new Byte[0];
        }
        public void omitSubmission(User user, Course course)
        {
            
        }
        public double curveGrade(double newGrade)
        {
            return newGrade;
        }
        public void removeComment(string comment)
        {
            
        }
        public List<Submission> getSubmissions()
        {
            return new List<Submission>();
        }

    }
}