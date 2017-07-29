using System;

public class Controller
{
    public static void Main()
    {
        var input = string.Empty;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputParams = input.Split();
            var curCitizen = new Citizen(inputParams[0], inputParams[1], int.Parse(inputParams[2]));
            Console.WriteLine(((IPerson)curCitizen).GetName());
            Console.WriteLine(((IResident)curCitizen).GetName());
        }
    }
}