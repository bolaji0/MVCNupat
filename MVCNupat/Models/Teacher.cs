using System.ComponentModel.DataAnnotations;

namespace MVCNupat.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        public string TeacherName { get; set; }
        [Required]
        public string Age { get; set; }
        public double salary { get; set; }
    }
}
