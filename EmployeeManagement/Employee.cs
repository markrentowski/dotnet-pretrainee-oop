public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; private set; }

    public Employee(int id, string name, decimal salary)
    {
        Id = id;
        Name = name;
        if (name == null || name == "")
        {
            Console.WriteLine("Name cannot be empty. Setting name to 'Unknown'.");
            Name = "Unknown";
        }
        Salary = salary;
        if (salary < 0)
        {
            Console.WriteLine("Salary cannot be negative. Setting salary to 0.");
            Salary = 0;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary:C}");
    }

    public abstract void Work();
 
    public decimal ChangeSalary(decimal newSalary)
    {
        if (newSalary < 0)
        {
            Console.WriteLine("Salary cannot be negative. Salarty change aborted.");
        }
        else
        {
            Salary = newSalary;
            SalaryChanged?.Invoke(this, EventArgs.Empty);
        }
        return Salary;
    }

    public EventHandler SalaryChanged;
}