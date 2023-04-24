namespace Domain.Models;

public class Employee
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public decimal Salary { get; set; }
    public DateTime BirthDate { get; set; }
    public Department Department { get; set; }

    public Employee(string firstname, string lastname, decimal salary)
    {
        Firstname = firstname;
        Lastname = lastname;
        Salary = salary;
    }

    public Employee()
    {
        
    }
    
}