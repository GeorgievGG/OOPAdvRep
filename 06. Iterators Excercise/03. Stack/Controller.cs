using System;
using System.Linq;

public class Controller
{
    public static void Main()
    {
        var input = string.Empty;
        var customStack = new Stack<int>(); try
        {
            while ((input = Console.ReadLine()) != "END")
            {
                var inputParams = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                ExecuteCommand(customStack, inputParams);
            }
            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in customStack)
            {
                Console.WriteLine(element);
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }

    private static void ExecuteCommand(Stack<int> cs, string[] inputParams)
    {
        switch (inputParams[0])
        {
            case "Push":
                cs.Push(inputParams.Skip(1).Select(int.Parse).ToArray());
                break;
            case "Pop":
                cs.Pop();
                break;
            default:
                break;
        }
    }
}