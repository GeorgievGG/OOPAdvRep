using System.Collections.Generic;

public class NameComparer<T> : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var returned = 0;
        if (x.Name.Length != y.Name.Length)
        {
            returned = x.Name.Length.CompareTo(y.Name.Length);
        }
        else
        {
            returned = x.Name.ToLower().CompareTo(y.Name.ToLower());
        }
        return returned;
    }
}