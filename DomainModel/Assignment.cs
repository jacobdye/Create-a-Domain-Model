
namespace DomainModel
{
    public class Assignment
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private DateTime dueDate { get; set; }
        private double pointsPossible { get; set; }

        public Assignment(int id, string name, string description, DateTime dueDate, double pointsPossible)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.dueDate = dueDate;
            this.pointsPossible = pointsPossible;
        }
        public Assignment removeAssignment(Assignment assignment)
        {
            return assignment;
        }
        public List<Assignment> getAssignments()
        {
            return new List<Assignment>();
        }
        public Assignment openAssignment(Assignment assignment)
        {
            return assignment;

        }
    }
}