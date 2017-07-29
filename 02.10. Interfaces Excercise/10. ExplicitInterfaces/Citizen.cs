public class Citizen : IResident, IPerson
{
    public Citizen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

    private string name;
    private int age;
    private string country;

    public string Name
    {
        get
        {
            return name;
        }

        private set
        {
            name = value;
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        private set
        {
            age = value;
        }
    }

    public string Country
    {
        get
        {
            return country;
        }

        private set
        {
            country = value;
        }
    }

    string IPerson.GetName()
    {
        return this.Name;
    }

    string IResident.GetName()
    {
        return $"Mr/Ms/Mrs " + this.Name;
    }
}