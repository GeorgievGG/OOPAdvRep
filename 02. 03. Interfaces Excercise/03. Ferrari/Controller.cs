using System;
public class Controller
{
    public static void Main()
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
        var input = Console.ReadLine();
        var x = new Ferrari(input);
        Console.WriteLine($"{x.Model}/{x.PushBrakes()}/{x.PushGas()}/{x.DriverName}");
    }
}