using Lab2.Models;

namespace Lab2.Services
{
    public class StudentMoc : IEntity<Student>
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id= 1, Name = "Omar",Username="Omar"},
            new Student(){Id= 2, Name = "Ahmed",Username="Ahmed"},
            new Student(){Id= 3, Name = "Mohamed", Username = "Mohamed"},
            new Student(){Id= 4, Name = "Ali", Username = "Omar"},
        };

        public List<Student> GetAll()
        {
            return students;
        }
        public Student GetById(int id)
        {
            var std = students.FirstOrDefault(x => x.Id == id);
            return std;
        }
        public void Add(Student std)
        {
            students.Add(std);
        }
        public void Update(Student std)
        {
            var oldStd = GetById(std.Id);
            oldStd.Name = std.Name;
            oldStd.Username = std.Username;
        }
        public void Delete(int id)
        {
            Student std = GetById(id);
            students.Remove(std);
        }
    }
}
