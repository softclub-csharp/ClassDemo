using Domain.Models;
using Infrastructure.Services;

Console.WriteLine("Welcome to the registration app v1");
var employeeService = new EmployeeService();
while (true)
{
    Console.WriteLine(@" Press

    1 - Create new Employee 
    2 - Update Employee
    3 - Delete Employee
    4 - Show List of employees
    0 - Exit
    ");
    Console.Write("input-> ");
    var input = Console.ReadLine();
    
    if (input == "0") break;
    
    bool result = input switch
    {
        "1" => Add(),
        "2" => Update(),
        "3" => Delete(),
        "4" => Show(),
        _ => false
    };

    if (result == false)
        Console.WriteLine("Unknown Command");
}

bool Add()
{
    var emp = new Employee();
    Console.Write("Firstname: ");
    emp.Firstname = Console.ReadLine();
    Console.Write("Lastname: ");
    emp.Lastname = Console.ReadLine();
    Console.Write("Salary: ");
    emp.Salary = Convert.ToDecimal(Console.ReadLine());
        
    employeeService.AddEmployee(emp);
    return true;
}

bool Show()
{
    employeeService.Show();
    return true;
}

bool Delete()
{
    Console.Write("Enter the Id of the Employee to delete: ");
    int id = Convert.ToInt32(Console.ReadLine());
    employeeService.DeleteEmployee(id);
    return true;
}

bool Update()
{
    Console.Write("Enter the Id of the Employee to update: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    var employee = employeeService.GetEmployeeById(id);
    Console.Write($"{employee.Firstname} --> ");
    employee.Firstname = Console.ReadLine();
    Console.Write($"{employee.Lastname} --> ");
    employee.Lastname = Console.ReadLine();
    Console.Write($"{employee.Salary} --> ");
    employee.Salary = Convert.ToDecimal(Console.ReadLine());
    
    employeeService.Update(employee);
    return true;

}



