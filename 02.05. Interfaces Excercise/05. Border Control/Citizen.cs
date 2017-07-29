public class Citizen : IServant, IBirthable, IPerson, IBuyer
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = birthdate;
        this.Food = 0;
    }

    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

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

    public string ID
    {
        get
        {
            return id;
        }

        private set
        {
            id = value;
        }
    }

    public string Birthdate
    {
        get
        {
            return birthdate;
        }

        private set
        {
            birthdate = value;
        }
    }

    public int Food
    {
        get
        {
            return food;
        }

        set
        {
            food = value;
        }
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}