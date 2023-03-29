using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        // cho phép ứng dụng chỉ định khóa chính thay vì để DB tạo nó
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Key]
        public int CourseID109 { get; set; }
        public string Title109 { get; set; }
        public int Credits109 { get; set; }

        public ICollection<Enrollment> Enrollments109 { get; set; }
    }
}