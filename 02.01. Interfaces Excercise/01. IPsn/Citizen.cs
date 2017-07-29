using System;

public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = birthdate;
    }
    private string name;
    private int age;
    private string id;
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
}