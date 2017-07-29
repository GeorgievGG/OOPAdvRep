using System.Collections.Generic;

public class AgeComparer<T> : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }
}