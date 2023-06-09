using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrudV1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Student Surname")]
        [Required(ErrorMessage = "This field is required.")]
        public string StudentSurname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string StudentName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Course Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string StudentCourse { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string PhoneNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        [DisplayName("Date Registration")]
        public DateTime Date { get; set; }


        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Email")]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        
    }
}
