using System;
using System.Linq;

namespace _07.CustomList
{
    public class Controller
    {
        public static void Main()
        {
            var input = string.Empty;
            var cl = new CustomList<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                var inputParams = input.Split();
                switch (inputParams[0])
                {
                    case "Add":
                        cl.Add(inputParams[1]);
                        break;
                    case "Remove":
                        cl.Remove(int.Parse(inputParams[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(cl.Contains(inputParams[1]));
                        break;
                    case "Swap":
                        cl.Swap(int.Parse(inputParams[1]), int.Parse(inputParams[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(cl.CountGreaterThan(inputParams[1]));
                        break;
                    case "Max":
                        Console.WriteLine(cl.Max());
                        break;
                    case "Min":
                        Console.WriteLine(cl.Min());
                        break;
                    case "Print":
                        cl.List.ToList().ForEach(x => Console.WriteLine(x));
                        break;
                    case "Sort":
                        cl.Sort();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
