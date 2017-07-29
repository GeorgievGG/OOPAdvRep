using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    public static void Main()
    {
        var soldiers = new List<Soldier>();
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputParams = input.Split();
            try
            {
                switch (inputParams[0])
                {
                    case "Private":
                        soldiers.Add(new Private(inputParams[1], inputParams[2], inputParams[3], double.Parse(inputParams[4])));
                        break;
                    case "LeutenantGeneral":
                        var privatesUnderCommand = new List<IPrivate>();
                        for (int i = 5; i < inputParams.Length; i++)
                        {
                            privatesUnderCommand.Add((IPrivate)soldiers.Where(x => x.Id == inputParams[i]).First());
                        }
                        soldiers.Add(new LeutenantGeneral(inputParams[1], inputParams[2], inputParams[3], double.Parse(inputParams[4]), privatesUnderCommand));
                        break;
                    case "Engineer":
                        soldiers.Add(new Engineer(inputParams[1], inputParams[2], inputParams[3], double.Parse(inputParams[4]), inputParams[5], inputParams.Skip(6).ToArray()));
                        break;
                    case "Commando":
                        soldiers.Add(new Commando(inputParams[1], inputParams[2], inputParams[3], double.Parse(inputParams[4]), inputParams[5], inputParams.Skip(6).ToArray()));
                        break;
                    case "Spy":
                        soldiers.Add(new Spy(inputParams[1], inputParams[2], inputParams[3], int.Parse(inputParams[4])));
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException)
            {
                continue;
            }
        }
        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier.ToString().Trim());
        }
    }
}