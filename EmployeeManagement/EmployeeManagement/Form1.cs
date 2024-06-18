using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        //List for storing employees
        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddEmploye_Click(object sender, EventArgs e)
        {

            int id = int.Parse(TxtId.Text);
            string name = TxtName.Text;
            string position = TxtPosition.Text;
            double salary = double.Parse(TxtSalary.Text);

            // Create a new employee and add him/her to the list
            Employee employee = new Employee(id, name, position, salary);
            employees.Add(employee);

            // Display employee information
            employee.DisplayInfo();

            // Update employee count on the label
            LblEmployeeCount.Text = $"Number of Employees: {Employee.GetEmployeeCount()}";
        }
    }
}
