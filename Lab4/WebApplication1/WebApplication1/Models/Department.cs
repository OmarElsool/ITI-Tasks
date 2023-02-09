using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

    }
}
