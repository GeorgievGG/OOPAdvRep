using System;
using System.Collections.Generic;

public class Controller
{
    public static void Main()
    {
        //Task 6
        //var ageSS = new SortedSet<Person>(new AgeComparer<Person>());
        //var nameSS = new SortedSet<Person>(new NameComparer<Person>());
        //Task 7
        var ss = new SortedSet<Person>();
        var hs = new HashSet<Person>();
        var incomingLinse = int.Parse(Console.ReadLine());
        for (int i = 0; i < incomingLinse; i++)
        {
            var inputParams = Console.ReadLine().Split();
            var curPsn = new Person(inputParams[0], int.Parse(inputParams[1]));
            curPsn.GetHashCode();
            ss.Add(curPsn);
            hs.Add(curPsn);
        }
        //Task 6
        //foreach (var name in nameSS)
        //{
        //    Console.WriteLine(name);
        //}
        //foreach (var age in ageSS)
        //{
        //    Console.WriteLine(age);
        //}
        //Task 7
        Console.WriteLine(ss.Count);
        Console.WriteLine(hs.Count);
    }
}