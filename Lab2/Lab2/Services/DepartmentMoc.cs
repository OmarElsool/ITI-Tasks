using Lab2.Models;

namespace Lab2.Services
{

    public class DepartmentMoc : IEntity<Department>
    {
        static List<Department> departments = new List<Department>()
        {
            new Department() { DeptId = 1, DepartmentName = "SD", Capacity=20 },
            new Department() { DeptId = 2, DepartmentName = "Web", Capacity=30 },
            new Department() { DeptId = 3, DepartmentName = "Mobile", Capacity=50 }
        };

        public List<Department> GetAll()
        {
            return departments;
        }
        public Department GetById(int id)
        {
            var dept = departments.FirstOrDefault(x => x.DeptId == id);
            return dept;
        }
        public void Add(Department dept)
        {
            departments.Add(dept);
        }
        public void Update(Department dept)
        {
            var oldStd = GetById(dept.DeptId);
            oldStd.DepartmentName = dept.DepartmentName;
            oldStd.Capacity = dept.Capacity;
        }
        public void Delete(int id)
        {
            Department dept = GetById(id);
            departments.Remove(dept);
        }
    }
}
