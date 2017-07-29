using System;
using System.Collections.Generic;
public class Controller
{
    public static void Main()
    {
        var input = string.Empty;
        var people = new List<Person>();
        while ((input = Console.ReadLine()) != "END")
        {
            var inputParams = input.Split();
            people.Add(new Person(inputParams[0], int.Parse(inputParams[1]), inputParams[2]));
        }
        var reqItem = int.Parse(Console.ReadLine());
        Person reqPsn = null;
        try
        { 
            reqPsn = people[reqItem];
        }
        catch (Exception)
        {
            Console.WriteLine("No matches");
            return;
        }
        var equal = 0;
        var notEqual = 0;
        foreach (var person in people)
        {
            if (person.CompareTo(reqPsn) == 0)
            {
                equal++;
            }
            else
            {
                notEqual++;
            }
        }
        Console.WriteLine($"{equal} {notEqual} {people.Count}");
    }
}