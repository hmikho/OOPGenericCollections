namespace Lab7.OOP;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, string gender, decimal salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Id: {Id} Name: {Name} Gender: {Gender} Salary: {Salary}";
    }
}

class List
{
    static void Main()
    {
        Employee ep1 = new Employee(101, "Hanna", "Female", 80000);
        Employee ep2 = new Employee(102, "Linus", "Male", 55000);
        Employee ep3 = new Employee(103, "Maria", "Female", 60000);
        Employee ep4 = new Employee(104, "Thorfinn", "Male", 70000);
        Employee ep5 = new Employee(105, "Melina", "Female", 70000);
    
        List<Employee> employeeList = new List<Employee> { ep1, ep2, ep3, ep4, ep5 };

        if (employeeList.Contains(ep2))
        {
            Console.WriteLine("Employee 2 objects exist in the list");
        }
        else
        {
            Console.WriteLine("Employee 2 objects do not exist in the list");
        }
    
        Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");
        if (firstMaleEmployee != null)
        {
            Console.WriteLine("First male employee: " + firstMaleEmployee);
        }
        else
        {
            Console.WriteLine("No male employees found in the list");
        }
        List<Employee> allMaleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
        Console.WriteLine("All male employees:");
        foreach (var maleEmployee in allMaleEmployees)
        {
            Console.WriteLine(maleEmployee);
        }
    }
}
