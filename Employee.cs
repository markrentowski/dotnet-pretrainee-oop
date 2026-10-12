public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; private set; }

    public Employee(int id, string name, decimal salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    public abstract void Work();

    public ChangeSalary(decimal newSalary)
    {
        if (newSalary < 0)
        {
            Console.WriteLine("Salary cannot be negative.");
        }
        else
        {
            Salary = newSalary;
            Console.WriteLine($"{Name}'s salary has been changed to {Salary:C}.");
        }
        
    }
}