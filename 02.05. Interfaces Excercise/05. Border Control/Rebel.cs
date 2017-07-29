public class Rebel : IBuyer, IPerson
{
    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = 0;
    }

    private string name;
    private int age;
    private string group;
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

    public string Group
    {
        get
        {
            return group;
        }

        set
        {
            group = value;
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
        this.Food += 5;
    }
}