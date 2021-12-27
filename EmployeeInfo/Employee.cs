using System;

namespace EmployeeInfo
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime FireDate { get; set; }
        public string Comments { get; set; }
        public decimal Salary { get; set; }
    }
}
