using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int? DeptId { get; set; }

        [ForeignKey(name: "DeptId")]
        public virtual Department Department { get; set; }

        public virtual ICollection<StudentCourse> StudentCrs { get; set; } = new HashSet<StudentCourse>();
    }
}
