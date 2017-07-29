using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string corps, string[] repairParams) : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new Dictionary<string, int>();
        for (int i = 0; i < repairParams.Length; i += 2)
        {
            repairs.Add(repairParams[i], int.Parse(repairParams[i + 1]));
        }
    }
    private Dictionary<string, int> repairs;

    public IReadOnlyDictionary<string, int> Repairs
    {
        get
        {
            return repairs;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"Corps: {this.Corps}");
        if (repairs.Count > 0)
        {
            sb.AppendLine("Repairs:");
            foreach (var rep in repairs)
            {
                sb.AppendLine($"  Part Name: {rep.Key} Hours Worked: {rep.Value}");
            }
        }
        else
        {
            sb.Append("Repairs:");
        }
        return sb.ToString();
    }
}