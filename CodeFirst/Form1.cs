using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        CodeFirst Ent = new CodeFirst();
        public int SelectedDeptId { get; set; }
        public int SelectedEmpId { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void fillComboBoxDepartment()
        {
            comboBox1.Items.Clear();
            var departments = Ent.Departments.Select(d => d);
            foreach (var department in departments)
            {
                comboBox1.Items.Add(department.Id);
            }
        }
        private void fillComboBoxEmployee(Department dept)
        {
            comboBox2.Items.Clear();
            foreach (var emp in dept.Employees)
            {
                comboBox2.Items.Add(emp.Id);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            fillComboBoxDepartment();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedDeptId = int.Parse(comboBox1.GetItemText(comboBox1.SelectedItem));
            Department department = Ent.Departments.Where(d => d.Id == SelectedDeptId).FirstOrDefault();
            comboBox2.Items.Clear();

            DepartmentIdBox.Text = department.Id.ToString();
            DepartmentNameBox.Text = department.Name;
            fillComboBoxEmployee(department);

        }

        private void InsertDept_Click(object sender, EventArgs e)
        {
            if (DepartmentNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }
            var result = new Department
            {
                Name = DepartmentNameBox.Text,
            };
            Ent.Departments.Add(result);
            Ent.SaveChanges();
            fillComboBoxDepartment();
            MessageBox.Show("Inserted Successfully");
        }

        private void UpdateDept_Click(object sender, EventArgs e)
        {
            var Dept = Ent.Departments.Find(SelectedDeptId);
            if (Dept == null)
            {
                MessageBox.Show("This Id Is Not Avaliable");
                return;
            }
            if (DepartmentNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }
            Dept.Name = DepartmentNameBox.Text;
            Ent.SaveChanges();
            MessageBox.Show("Updated Successfully");
        }

        private void DeleteDept_Click(object sender, EventArgs e)
        {
            var Dept = Ent.Departments.Find(SelectedDeptId);
            if (Dept == null)
            {
                MessageBox.Show("This Id Is Not Avaliable");
                return;
            }
            Ent.Departments.Remove(Dept);
            Ent.SaveChanges();
            fillComboBoxDepartment();
            MessageBox.Show("Department Deleted");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEmpId = int.Parse(comboBox2.GetItemText(comboBox2.SelectedItem));
            var employee = Ent.Employees.Where(em => em.Id == SelectedEmpId).FirstOrDefault();

            EmployeeIdBox.Text = employee.Id.ToString();
            EmployeeNameBox.Text = employee.Name;

        }

        private void InsertEmp_Click(object sender, EventArgs e)
        {
            var department = Ent.Departments.Where(d => d.Id == SelectedDeptId).FirstOrDefault();

            if (department == null)
            {
                MessageBox.Show("Select Department To insert Into");
                return;
            }
            if (EmployeeNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }

            Employee employee = new Employee
            {
                Name = EmployeeNameBox.Text,
                DepartmentId = SelectedDeptId
            };

            Ent.Employees.Add(employee);
            Ent.SaveChanges();
            MessageBox.Show("Employee Added Successfully");
            fillComboBoxEmployee(department);
            EmployeeNameBox.Text = "";
        }

        private void UpdateEmp_Click(object sender, EventArgs e)
        {
            var employee = Ent.Employees.Find(SelectedEmpId);
            if (employee == null)
            {
                MessageBox.Show("The Employee Not Found");
                return;
            }
            if (EmployeeNameBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter Valid Name");
                return;
            }

            employee.Name = EmployeeNameBox.Text;
            employee.DepartmentId = SelectedDeptId;
            Ent.SaveChanges();
            MessageBox.Show("Employee Updated Successfully");
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            var employee = Ent.Employees.Find(SelectedEmpId);
            if (employee == null)
            {
                MessageBox.Show("The Employee Not Found");
                return;
            }
            var department = Ent.Departments.Where(d => d.Id == employee.DepartmentId).FirstOrDefault();
            if (department == null)
            {
                MessageBox.Show("Not valid Department");
                return;
            }
            Ent.Employees.Remove(employee);
            Ent.SaveChanges();
            MessageBox.Show("Employee Removed");
            fillComboBoxEmployee(department);
        }
    }
}
