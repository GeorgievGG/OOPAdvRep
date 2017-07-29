using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<IPrivate> privates) : base(id, firstName, lastName, salary)
    {
        this.privates = new List<IPrivate>();
        this.privates.AddRange(privates);
    }
    private List<IPrivate> privates;

    public IReadOnlyList<IPrivate> Privates
    {
        get
        {
            return privates.AsReadOnly();
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        if (privates.Count > 0)
        {
            sb.AppendLine("Privates:");
            foreach (var prv in privates)
            {
                sb.AppendLine($"  {prv.ToString()}");
            }
        }
        else
        {
            sb.Append("Privates:");
        }
        return sb.ToString();
    }
}