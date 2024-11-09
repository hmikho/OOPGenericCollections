using System;
using System.Collections.Generic;

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
        return $"{Id} {Name} {Gender} {Salary}";
    }
}

class Stack
{
    static void Main()
    {
        Employee ep1 = new Employee(101, "Hanna", "Female", 80000);
        Employee ep2 = new Employee(102, "Linus", "Male", 55000);
        Employee ep3 = new Employee(103, "Maria", "Female", 60000);
        Employee ep4 = new Employee(104, "Thorfinn", "Male", 70000);
        Employee ep5 = new Employee(105, "Melina", "Female", 70000);

        
        Stack<Employee> employeeStack = new Stack<Employee>();
        employeeStack.Push(ep1);
        employeeStack.Push(ep2);
        employeeStack.Push(ep3);
        employeeStack.Push(ep4);
        employeeStack.Push(ep5);
        
        Console.WriteLine("Items left in the Stack = " + employeeStack.Count);
        foreach (var employee in employeeStack)
        {
            Console.WriteLine(employee);
            Console.WriteLine("Items left in the Stack = " + employeeStack.Count);
        }

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Retrive Using Pop Method");
        while (employeeStack.Count > 0)
        {
            Employee ep = employeeStack.Pop();
            Console.WriteLine(ep);
            Console.WriteLine("Items left in the Stack = " + employeeStack.Count);
        }
        
        employeeStack.Push(ep1);
        employeeStack.Push(ep2);
        employeeStack.Push(ep3);
        employeeStack.Push(ep4);
        employeeStack.Push(ep5);

        Console.WriteLine("-----------------------------------------");
        
        Console.WriteLine("Retrive Using Peek Method");
        for (int i = 0; i < 2; i++)
        {
            Employee ep = employeeStack.Peek();
            Console.WriteLine(ep);
            Console.WriteLine("Items left in the Stack = " + employeeStack.Count);
        }

        Console.WriteLine("-----------------------------------------");
        
        Console.WriteLine("Ep3 is in stack");
        bool containsEp3 = employeeStack.Contains(ep3);
        Console.WriteLine("Ep3 is in stack: " + (containsEp3 ? "Yes" : "No"));
    }
}
