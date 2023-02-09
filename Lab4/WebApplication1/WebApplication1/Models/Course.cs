using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Course
    {
        [Key]
        public int CrsId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Department> Departments { get; set; } = new HashSet<Department>();

        public virtual ICollection<StudentCourse> CourseStd { get; set; } = new HashSet<StudentCourse>();
    }
}
