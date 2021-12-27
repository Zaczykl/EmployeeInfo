using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using EmployeeInfo.Properties;

namespace EmployeeInfo
{
    public partial class MainForm : Form
    {
        private List<Employee> _employeesList = new List<Employee>();        
        private FileHelper<List<Employee>> _fileHelper = new FileHelper<List<Employee>>();
        public bool isMaximize { 
            get 
            {
                return Settings.Default.isMaximize;
            } 
            set 
            {
                Settings.Default.isMaximize = value;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            LoadUserSettings();
            RefreshData();
            DataGridViewInit();
        }

        private void DataGridViewInit()
        {
            dataGridViewEmployees.Columns[nameof(Employee.Id)].Visible = false;
            dataGridViewEmployees.Columns[nameof(Employee.FirstName)].HeaderText = "Imię";
            dataGridViewEmployees.Columns[nameof(Employee.LastName)].HeaderText = "Nazwisko";
            dataGridViewEmployees.Columns[nameof(Employee.HireDate)].HeaderText = "Data zatrudnienia";
            dataGridViewEmployees.Columns[nameof(Employee.FireDate)].HeaderText = "Data zwolnienia";
            dataGridViewEmployees.Columns[nameof(Employee.Salary)].HeaderText = "Wynagrodzenie";
            dataGridViewEmployees.Columns[nameof(Employee.Comments)].HeaderText = "Uwagi";            
        }

        private void RefreshData()
        {
            _employeesList = _fileHelper.DeserializeFromFile(Program._path);
            dataGridViewEmployees.DataSource = _employeesList;
        }

        private void LoadUserSettings()
        {
            if (isMaximize)
                WindowState = FormWindowState.Maximized;
        }
        private void buttonHireEmployee_Click(object sender, EventArgs e)
        {
            HireEmployee();
        }

        private void buttonFireEmployee_Click(object sender, EventArgs e)
        {
            FireEmployee();
        }
        private void FireEmployee()
        {
           
            if (dataGridViewEmployees.SelectedRows.Count != 0)
            {
                int selectedEmployeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells[nameof(Employee.Id)].Value;
                FireEmployeeForm fireEmployeeForm = new FireEmployeeForm(_employeesList,selectedEmployeeId);
                fireEmployeeForm.ShowDialog();
                _fileHelper.SerializeToFile(Program._path, _employeesList);
                RefreshData();
            }
            else
                MessageBox.Show("Należy zaznaczyć jakiś wiersz.");
        }
        private void HireEmployee()
        {
            AddEditEmployeeForm addEditEmployeeForm = new AddEditEmployeeForm();
            addEditEmployeeForm.ShowDialog();
            RefreshData();
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count != 0)
            {
                _employeesList = _fileHelper.DeserializeFromFile(Program._path);
                int selectedEmployeeId = (int)dataGridViewEmployees.SelectedRows[0].Cells[nameof(Employee.Id)].Value;
                AddEditEmployeeForm addEditEmployeeForm = new AddEditEmployeeForm(selectedEmployeeId);
                addEditEmployeeForm.ShowDialog();
                RefreshData();
            }
            else
                MessageBox.Show("Należy zaznaczyć jakiś wiersz.");
        }

        private void checkBoxHideFiredEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHideFiredEmployees.Checked)
            {
               List<Employee> workingEmployees = _employeesList.Where(x => x.FireDate == default).ToList();
                dataGridViewEmployees.DataSource = workingEmployees;
            }
            else
                dataGridViewEmployees.DataSource = _employeesList;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (WindowState==FormWindowState.Maximized)
                isMaximize = true;
            else
                isMaximize = false;

            Settings.Default.Save();
        }
    }
}
