public class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(int id, string name, decimal salary, int teamSize) : base(id, name, salary)
    {
        TeamSize = teamSize;
    }
    public override void Work()
    {
        Console.WriteLine($"Manager {Name} is managing a team of {TeamSize} people.");
    }
}