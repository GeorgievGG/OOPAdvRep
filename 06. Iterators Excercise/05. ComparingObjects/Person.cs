using System;

public class Person : IComparable<Person>
{
    public Person(string name, int age, string town)
    {
        this.name = name;
        this.age = age;
        this.town = town;
    }
    private string name;
    private int age;
    private string town;
    public int CompareTo(Person other)
    {
        var returned = 0;
        if (this.name != other.name)
        {
            returned = this.name.CompareTo(other.name);
        }
        else if (this.age != other.age)
        {
            returned = this.age.CompareTo(other.age);
        }
        else if (this.town != other.town)
        {
            returned = this.town.CompareTo(other.town);
        }
        return returned;
    }
}