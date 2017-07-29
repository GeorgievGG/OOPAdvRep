using System;

public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        this.Model = "488-Spider";
        this.DriverName = driverName;
    }

    private string model;
    private string driverName;

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

    public string DriverName
    {
        get
        {
            return driverName;
        }

        private set
        {
            driverName = value;
        }
    }

    public string PushBrakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }
}