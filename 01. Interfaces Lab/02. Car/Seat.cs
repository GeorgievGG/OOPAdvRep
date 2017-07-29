using System.Text;

public class Seat : ICar
{
    public Seat(string model, string color)
    {
        this.Color = color;
        this.Model = model;
    }

    private string color;
    private string model;

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
        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}