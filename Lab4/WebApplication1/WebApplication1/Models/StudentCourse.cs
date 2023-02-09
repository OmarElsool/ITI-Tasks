using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class StudentCourse
    {
        [ForeignKey("CourseStd")]
        public int CrsId { get; set; }
        [ForeignKey("StudentCrs")]
        public int StdId { get; set; }

        public int? Degree { get; set; }

        public virtual Student StudentCrs { get; set; }
        public virtual Course CourseStd { get; set; }
    }
}
