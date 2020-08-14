using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace August12application.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                //read
                //string @EmployeeId - 1
                //SELECT name, gender, city, salary, address FROM
                //Employees
                //WHERE Employee = @EmployeeId

                EmployeeId = 10,
                Name = "Flora",
                Gender = "Female",
                City = "Hope Mills",
                Salary = 7000,
                Address = "Cone Shell"
            };
            return employee;
        }
    }
}
