using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> data;
    public Stack()
    {
        this.data = new List<T>();
    }
    public void Push(params T[] elements)
    {
        this.data.AddRange(elements);
    }

    public void Pop()
    {
        if (this.data.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
        data.RemoveAt(this.data.Count - 1);
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = data.Count - 1; i >= 0; i--)
        {
            yield return data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}