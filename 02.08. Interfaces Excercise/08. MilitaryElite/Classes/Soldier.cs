using System;

public abstract class Soldier : ISoldier
{
    public Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    private string id;
    private string firstName;
    private string lastName;

    public string Id
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

    public string FirstName
    {
        get
        {
            return firstName;
        }

        private set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }

        private set
        {
            lastName = value;
        }
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}