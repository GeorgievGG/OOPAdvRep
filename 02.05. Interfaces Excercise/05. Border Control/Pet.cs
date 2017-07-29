internal class Pet : IBirthable
{
    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    private string name;
    private string birthdate;

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
}