using System;

public class Controller
{
    public static void Main()
    {
        var inputParams1 = Console.ReadLine().Split();
        Console.WriteLine((new Threeuple<string, string, string>(inputParams1[0] + " " + inputParams1[1], inputParams1[2], inputParams1[3])));
        var inputParams2 = Console.ReadLine().Split();
        var drunk = false;
        if (inputParams2[2].ToLower() == "drunk")
        {
            drunk = true;
        }
        Console.WriteLine((new Threeuple<string, int, bool>(inputParams2[0], int.Parse(inputParams2[1]), drunk)));
        var inputParams3 = Console.ReadLine().Split();
        Console.WriteLine((new Threeuple<string, double, string>(inputParams3[0], double.Parse(inputParams3[1]), inputParams3[2])));
    }
}