using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : IEnumerable<T> where T : IComparable
{
    public CustomList()
    {
        this.list = new List<T>();
    }

    private List<T> list;

    public IReadOnlyList<T> List
    {
        get
        {
            return list.AsReadOnly();
        }
    }

    public void Add(T element)
    {
        list.Add(element);
    }
    public T Remove(int index)
    {
        var returnElement = List[index];
        list.RemoveAt(index);
        return returnElement;
    }
    public bool Contains(T element)
    {
        return List.Contains(element);
    }
    public void Swap(int index1, int index2)
    {
        var toBeSwapped = this.list[index1];
        this.list[index1] = List[index2];
        this.list[index2] = toBeSwapped;
    }
    public int CountGreaterThan(T element)
    {
        var counter = 0;
        foreach (var item in List)
        {
            if (item.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }
    public T Max()
    {
        return List.Max();
    }
    public T Min()
    {
        return List.Min();
    }
    public void Sort()
    {
        list.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
