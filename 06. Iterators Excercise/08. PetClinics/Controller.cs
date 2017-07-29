using System;
using System.Collections.Generic;

public class Controller
{
    public static void Main()
    {
        var incomintLines = int.Parse(Console.ReadLine());
        var pets = new Dictionary<string, Pet>();
        var clinics = new Dictionary<string, Clinic>();
        for (int i = 0; i < incomintLines; i++)
        {
            var inputParams = Console.ReadLine().Split();
            try
            {
                switch (inputParams[0])
                {
                    case "Create":
                        if (inputParams[1] == "Pet")
                        {
                            pets.Add(inputParams[2], new Pet(inputParams[2], int.Parse(inputParams[3]), inputParams[4]));
                        }
                        else if (inputParams[1] == "Clinic")
                        {
                            clinics.Add(inputParams[2], new Clinic(inputParams[2], int.Parse(inputParams[3])));
                        }
                        break;
                    case "Add":
                        Console.WriteLine(clinics[inputParams[2]].Add(pets[inputParams[1]]));
                        break;
                    case "Release":
                        Console.WriteLine(clinics[inputParams[1]].Release());
                        break;
                    case "HasEmptyRooms":
                        Console.WriteLine(clinics[inputParams[1]].HasEmptyRooms());
                        break;
                    case "Print":
                        if (inputParams.Length == 3)
                        {
                            Console.WriteLine(clinics[inputParams[1]].Print(int.Parse(inputParams[2]) - 1));
                        }
                        else
                        {
                            Console.WriteLine(clinics[inputParams[1]].Print());
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}