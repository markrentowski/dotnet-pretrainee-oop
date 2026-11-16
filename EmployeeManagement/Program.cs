List<Employee> employees = new List<Employee>
{
    new Developer(1, "Alice", 70000, "C#"),
    new Designer(2, "Bob", 65000, "Adobe Photoshop"),
    new Manager(3, "Charlie", 90000, 5),
    new Developer(4, "David", 75000, "Java"),
};

Console.WriteLine("1. Display all employees");
Console.WriteLine("2. Make all employees work");
Console.WriteLine("3. Change an employee's salary");
Console.WriteLine("4. Generate a report");
Console.WriteLine("5. Exit");
 
int userChoice;

do
{
    Console.Write("Choose an option: ");
    string input = Console.ReadLine();
    if (input.Length == 1 && "12345".Contains(input))
    {
        userChoice = int.Parse(input);
        break; 
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
    }
} 
while (true);

switch (userChoice)
{
    case 1:
        DisplayAllEmployees(employees);
        break;
    case 2:
        MakeAllEmployeesWork(employees);
        break;
    case 3:
        ChangeEmployeeSalary(employees);
        break;
    case 4:
        GenerateReport(employees);
        break;
    case 5:
        Console.WriteLine("Exiting the program.");
        return;
    default:
        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
        break;
}


void DisplayAllEmployees(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        employee.DisplayInfo();
    }
}

void MakeAllEmployeesWork(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        employee.Work();
    }
}

void ChangeEmployeeSalary(List<Employee> employees)
{
    Console.Write("Enter the employee ID to change salary: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        employee.SalaryChanged += SalaryChangedHandler;
        if (employee != null)
        {
            Console.Write($"Enter new salary for {employee.Name}: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal newSalary))
            {
                employee.ChangeSalary(newSalary);
                employee.SalaryChanged += (sender, e) =>
                {
                    Console.WriteLine($"Notification: {employee.Name}'s salary has been updated to {employee.Salary:C}.");
                };
            }
            else
            {
                Console.WriteLine("Invalid salary input. Salary change aborted.");
            }
        }
        else
        {
            Console.WriteLine($"No employee found with ID {id}.");
        }
    }
    else
    {
        Console.WriteLine("Invalid ID input. Salary change aborted.");
    }
}

void SalaryChangedHandler(object sender, EventArgs e)
{
    if (sender is Employee employee)
    {
        Console.WriteLine($"Notification: {employee.Name}'s salary has been updated to {employee.Salary:C}.");
    }
}

void GenerateReport(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        if (employee is IReportable reportableEmployee)
        {
            reportableEmployee.GenerateReport();
        }
    }
}
