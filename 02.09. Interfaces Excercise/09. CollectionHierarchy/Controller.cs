using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Controller
{
    public static void Main()
    {
        var ac = new AddCollection<string>();
        var arc = new AddRemoveCollection<string>();
        var mc = new MyList<string>();
        var inputStrings = Console.ReadLine().Split();
        var sb1 = new StringBuilder();
        var sb2 = new StringBuilder();
        var sb3 = new StringBuilder();
        foreach (var str in inputStrings)
        {
            sb1.Append($"{ac.Add(str)} ");
            sb2.Append($"{arc.Add(str)} ");
            sb3.Append($"{mc.Add(str)} ");
        }
        var removes = int.Parse(Console.ReadLine());
        var sb4 = new StringBuilder();
        var sb5 = new StringBuilder();
        for (int i = 0; i < removes; i++)
        {
            sb4.Append($"{arc.Remove()} ");
            sb5.Append($"{mc.Remove()} ");
        }
        var addSb = new StringBuilder();
        addSb.AppendLine(sb1.ToString().Trim());
        addSb.AppendLine(sb2.ToString().Trim());
        addSb.AppendLine(sb3.ToString().Trim());
        addSb.AppendLine(sb4.ToString().Trim());
        addSb.Append(sb5.ToString().Trim());
        Console.WriteLine(addSb.ToString());
    }
}