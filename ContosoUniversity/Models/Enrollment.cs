using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        [Key]
        public int EnrollmentID109 { get; set; }
        public int CourseID109 { get; set; }
        public int StudentID109 { get; set; }


        // chỉ định format dữ liệu
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade109 { get; set; }

        public Course Course109 { get; set; }
        public Student Student109 { get; set; }
    }
}