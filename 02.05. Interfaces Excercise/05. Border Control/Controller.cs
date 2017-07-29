using System;
using System.Collections.Generic;
using System.Linq;
class Controller
{
    static void Main()
    {
        //TASK 1
        //var input = string.Empty;
        var registry = new Dictionary<string, IPerson>(); //Common for all tasks
        //var jail = new List<IServant>();
        //while ((input = Console.ReadLine()) != "End")
        //{
        //    var inputParams = input.Split();
        //    if (inputParams.Length == 3)
        //    {
        //        registry.Add(new Citizen(inputParams[0], int.Parse(inputParams[1]), inputParams[2]));
        //    }
        //    else
        //    {
        //        registry.Add(new Robot(inputParams[0], inputParams[1]));
        //    }
        //}
        //var falseSufix = Console.ReadLine();
        //foreach (var item in registry)
        //{
        //    if (item.ID.Substring(item.ID.Length - falseSufix.Length) == falseSufix)
        //    {
        //        jail.Add(item);
        //    }
        //}
        //jail.ForEach(x => Console.WriteLine(x.ID));

        //TASK 2
        //while ((input = Console.ReadLine()) != "End")
        //{
        //    var inputParams = input.Split();
        //    if (inputParams[0] == "Citizen")
        //    {
        //        registry.Add(new Citizen(inputParams[1], int.Parse(inputParams[2]), inputParams[3], inputParams[4]));
        //    }
        //    else if (inputParams[0] == "Pet")
        //    {
        //        registry.Add(new Pet(inputParams[1], inputParams[2]));
        //    }
        //}
        //var yearToCheck = Console.ReadLine().Trim();
        //foreach (var entity in registry.Where(x => x.Birthdate.Substring(x.Birthdate.LastIndexOf('/') + 1) == yearToCheck))
        //{
        //    Console.WriteLine(entity.Birthdate);
        //}

        //TASK 3
        var incomingLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < incomingLines; i++)
        {
            var inputParams = Console.ReadLine().Split();
            if (inputParams.Length == 4)
            {
                registry.Add(inputParams[0], new Citizen(inputParams[0], int.Parse(inputParams[1]), inputParams[2], inputParams[3]));
            }
            else
            {
                registry.Add(inputParams[0], new Rebel(inputParams[0], int.Parse(inputParams[1]), inputParams[2]));
            }
        }
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            if (registry.ContainsKey(input))
            {
                registry[input].BuyFood();
            }
        }
        Console.WriteLine(registry.Sum(x => x.Value.Food));
    }
}