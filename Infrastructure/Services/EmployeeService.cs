using Domain.Models;

namespace Infrastructure.Services;

public class EmployeeService
{
    private List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
    }

    //Create
    public void AddEmployee(Employee employee)
    {
        employee.Id = _employees.Count + 1;
        _employees.Add(employee);
    }
    
    //Read
    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    
    //Read By id
    public Employee GetEmployeeById(int id)
    {
        foreach (var employee in _employees)
        {
            if (employee.Id == id) return employee;
        }

        return null;
    }
    
    
    //Update
    public Employee Update(Employee employee)
    {
        foreach (var e in _employees)
        {
            if (e.Id == employee.Id)
            {
                e.Firstname = employee.Firstname;
                e.Lastname = employee.Lastname;
                e.Salary = employee.Salary;
                e.BirthDate = employee.BirthDate;

                return e;
            }
        }
        return employee;
    }
    
    
    //delete
    public void DeleteEmployee(int id)
    {
        Employee emp = new Employee();
        foreach (var employee in _employees)
        {
            if (employee.Id == id) emp = employee;
        }

        _employees.Remove(emp);
    }

    public void Show()
    {
        Console.WriteLine("Id|       Firstname|        LastName|        Salary");
        foreach (var employee in _employees)
        {
            Console.WriteLine($"{employee.Id}|       {employee.Firstname}|        {employee.Lastname}|        {employee.Salary}");
        }
    }

    public int CountEmployee()
    {
        return _employees.Count;
    }
    
    //CRUD
    //Create (add)
    //Read
    //Update
    //Delete
}