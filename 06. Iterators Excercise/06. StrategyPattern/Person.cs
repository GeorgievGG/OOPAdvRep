using System;

public class Person : IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    string name;
    int age;

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

    public int CompareTo(Person other)
    {
        if (this.Name != other.Name)
        {
            return this.Name.CompareTo(other.Name);
        }
        else if (this.Age != other.Age)
        {
            return this.Age.CompareTo(other.Age);
        }
        return 0;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }

    public override bool Equals(object obj)
    {
        return obj.GetHashCode().Equals(this.GetHashCode());
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            var x = this.name.GetHashCode();
            hash = hash * 23 + this.name.GetHashCode();
            hash = hash * 23 + this.age.GetHashCode();
            return hash;
        }
    }
}