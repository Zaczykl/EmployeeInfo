using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeInfo
{
    public partial class AddEditEmployeeForm : Form
    {
        private List<Employee> _employeesList;
        private int _employeeId;
        private FileHelper<List<Employee>> fileHelper = new FileHelper<List<Employee>>();
        private Employee selectedEmployee;
        private bool _adding;

        public AddEditEmployeeForm(int employeeId = 0)
        {
            InitializeComponent();
            _employeeId = employeeId;
            GetEmployeeData();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (_adding)
                AddEmployee();
            else
            EditEmployee();
        }

        private void AddEmployee()
        {
            if (textBoxFirstName.Text.Length != 0 && textBoxLastName.Text.Length != 0) 
            {
                _employeesList = fileHelper.DeserializeFromFile(Program._path);
                _employeesList.Add(new Employee
                {
                    Id = _employeeId,
                    FirstName = textBoxFirstName.Text,
                    LastName = textBoxLastName.Text,
                    HireDate = dateTimePickerHireDate.Value.Date,
                    Salary = numericUpDownSalary.Value,
                    Comments = textBoxComments.Text
                });

                fileHelper.SerializeToFile(Program._path, _employeesList);
                Close();
            }
            else
                MessageBox.Show("Należy podać Imię i Nazwisko.");
        }

        private void EditEmployee()
        {
            selectedEmployee.FirstName = textBoxFirstName.Text;
            selectedEmployee.LastName = textBoxLastName.Text;
            selectedEmployee.HireDate = dateTimePickerHireDate.Value;
            selectedEmployee.Comments = textBoxComments.Text;
            selectedEmployee.Salary = numericUpDownSalary.Value;
            fileHelper.SerializeToFile(Program._path, _employeesList);
            Close();
        }
        
        private void GetEmployeeData()
        {
            _employeesList = fileHelper.DeserializeFromFile(Program._path);
            if (_employeeId == 0)
            {
                _adding = true;
                Employee lastEmployee = _employeesList.OrderByDescending(x => x.Id).FirstOrDefault();
                _employeeId = lastEmployee == null ? 1 : lastEmployee.Id + 1;
            }
            else
            {
                selectedEmployee = _employeesList.Where(x => x.Id == _employeeId).FirstOrDefault();
                textBoxFirstName.Text = selectedEmployee.FirstName;
                textBoxLastName.Text = selectedEmployee.LastName;
                dateTimePickerHireDate.Value = selectedEmployee.HireDate;
                textBoxComments.Text = selectedEmployee.Comments;
                numericUpDownSalary.Value = selectedEmployee.Salary;
            }
        }
    }
}
