using System;
using System.Linq;
using System.Text;

public class Controller
{
    public static void Main()
    {
        var input = string.Empty;
        var createInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var li = new ListyIterator<string>(createInput.Skip(1).ToArray());
        while ((input = Console.ReadLine()) != "END")
        {
            var inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                ExecuteCommand(li, inputParams);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                continue;
            }
        }
    }

    private static void ExecuteCommand(ListyIterator<string> li, string[] inputParams)
    {
        switch (inputParams[0])
        {
            case "Print":
                li.Print();
                break;
            case "HasNext":
                Console.WriteLine(li.HasNext());
                break;
            case "Move":
                Console.WriteLine(li.Move());
                break;
            case "PrintAll":
                var sb = new StringBuilder();
                foreach (var element in li)
                {
                    sb.Append($"{element} ");
                }
                Console.WriteLine(sb.ToString().Trim());
                break;
            default:
                break;
        }
    }
}