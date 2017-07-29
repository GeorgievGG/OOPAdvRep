using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IListyIterator<T>, IEnumerable<T>
{
    public ListyIterator(params T[] elements)
    {
        this.elements = new List<T>(elements);
        this.curIndex = 0;
    }

    private List<T> elements;
    private int curIndex;

    public bool HasNext()
    {
        return curIndex < this.elements.Count - 1;
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            curIndex++;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (this.elements.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        Console.WriteLine(this.elements[curIndex]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.elements.Count; i++)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}