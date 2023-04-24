using Domain.Models;
using Infrastructure.Services;

var employeeService = new EmployeeService();

var emp1 = new Employee("Firstaname1", "LastName1",123);
var emp2 = new Employee("Firstaname2", "LastName2",123);

employeeService.AddEmployee(emp1);
employeeService.AddEmployee(emp2);

Console.ReadLine();
employeeService.Show();

emp1 = employeeService.GetEmployeeById(1);
emp1.Firstname = "Abdulloh";
emp1.Lastname = "Abdulloev";
emp1.Salary = 5000m;

employeeService.Update(emp1);

Console.ReadLine();
employeeService.Show();

employeeService.DeleteEmployee(1);

Console.ReadLine();
employeeService.Show();




