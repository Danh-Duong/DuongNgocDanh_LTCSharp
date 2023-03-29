using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ContosoUniversity.Models
{
    public class Student
    {
        [Key]
        public int ID109 { get; set; }


        //thiết lập tiêu đề này thay cho tên mặc định của thuộc tính, sử dụng [Display]
        [StringLength(255, MinimumLength =2,ErrorMessage ="{0} phải dài từ {2} đến {1}")]
        [Required(ErrorMessage ="{0} không được để trống")]
        [DisplayName("LastName")]
        public string LastName109 { get; set; }

        [Required(ErrorMessage = "{0} không được để trống")]
        [DisplayName("FirstMidName")]
        public string FirstMidName109 { get; set; }


        [Required(ErrorMessage = "{0} không được để trống")]
        [DisplayName("EnrollmentDate")]
        public DateTime EnrollmentDate109 { get; set; }

        
        public ICollection<Enrollment> Enrollments109 { get; set; }
    }
}