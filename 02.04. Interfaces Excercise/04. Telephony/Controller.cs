using System;
public class Controller
{
    public static void Main()
    {
        var phones = Console.ReadLine().Split();
        var sites = Console.ReadLine().Split();
        var sphone = new Smartphone();
        foreach (var phone in phones)
        {
            Console.WriteLine(sphone.Call(phone)); 
        }
        foreach (var link in sites)
        {
            Console.WriteLine(sphone.Connect(link));
        }
    }
}