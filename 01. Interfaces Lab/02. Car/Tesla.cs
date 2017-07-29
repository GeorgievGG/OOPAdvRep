using System.Text;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Color = color;
        this.Model = model;
        this.Battery = battery;
    }

    private string color;
    private string model;
    private int battery;

    public string Color
    {
        get
        {
            return color;
        }

        private set
        {
            color = value;
        }
    }

    public string Model
    {
        get
        {
            return model;
        }

        private set
        {
            model = value;
        }
    }

    public int Battery
    {
        get
        {
            return battery;
        }

        private set
        {
            battery = value;
        }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}