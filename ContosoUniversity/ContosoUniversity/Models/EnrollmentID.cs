namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        //The question mark after the Grade type declaration indicates that the Grade property is nullable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}