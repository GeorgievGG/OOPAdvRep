using System.Collections.Generic;

public class Box<T> : IBox<T>
{
    public Box()
    {
        this.list = new List<T>();
    }
    private IList<T> list;
    private int count => this.list.Count;

    public int Count
    {
        get
        {
            return count;
        }
    }

    public void Add(T element)
    {
        list.Add(element);
    }

    public T Remove()
    {
        var toBeReturned = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        return toBeReturned;
    }
}