using System;
using System.Linq;
using System.Text;
public class Froggy
{
    public static void Main()
    {
        var incomingStones = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var lake = new Lake(incomingStones);
        var sb = new StringBuilder();
        foreach (var stone in lake)
        {
            sb.Append($"{stone}, ");
        }
        Console.WriteLine(sb.ToString().Substring(0, sb.ToString().Length - 2));
    }
}