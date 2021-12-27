using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeInfo
{
    public partial class FireEmployeeForm : Form
    {
        Employee selectedEmployee;
        public FireEmployeeForm(List<Employee> employeeList,int id)
        {
            InitializeComponent();
            selectedEmployee = employeeList.Where(x => x.Id == id).FirstOrDefault();
            LoadForm();

        }
        private void LoadForm()
        {
            if (selectedEmployee.FireDate != default)
            {
                checkBoxFired.Checked = true;
            }
        }

        private void checkBoxFired_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFired.Checked)
            {
                dateTimePickerFireDate.Visible = true;
                selectedEmployee.FireDate = DateTime.Now.Date;
            }
            else
            {
                dateTimePickerFireDate.Visible = false;
                selectedEmployee.FireDate = default;
            }
        }
        private void dateTimePickerFireDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime fireDate = dateTimePickerFireDate.Value.Date;
            if (fireDate<selectedEmployee.HireDate)
                MessageBox.Show("Nie można zwolnić pracownika przed jego zatrudnieniem.");
            else
            selectedEmployee.FireDate = fireDate;

        }
    }
}
