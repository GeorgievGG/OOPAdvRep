using System.Text.RegularExpressions;

public class Smartphone : ICallCapable, IInternetConectable
{
    public string Call(string number)
    {
        var rx = new Regex(@"[^0-9]");
        if (rx.IsMatch(number))
        {
            return "Invalid number!";
        }
        return $"Calling... {number}";
    }

    public string Connect(string link)
    {
        var rx = new Regex(@"[0-9]");
        if (rx.IsMatch(link))
        {
            return "Invalid URL!";
        }
        return $"Browsing: {link}!";
    }
}