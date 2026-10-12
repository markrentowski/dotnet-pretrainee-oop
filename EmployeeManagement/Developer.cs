public class Developer:Employee, IReportable
{
    public string ProgrammingLanguage { get; set; }
    public Developer(int id, string name, decimal salary, string programmingLanguage) : base(id, name, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public override void Work()
    {
        Console.WriteLine($"{Name} is writing {ProgrammingLanguage} code.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"Developer {Name} has generated a report for the {ProgrammingLanguage} project.");
    }
}