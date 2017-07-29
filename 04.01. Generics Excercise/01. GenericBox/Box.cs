using System;
using System.Collections.Generic;

public class Box <T> where T : IComparable
{
    public Box(T element)
    {
        this.Element = element;
    }
    private T element;

    public T Element
    {
        get
        {
            return element;
        }

        set
        {
            element = value;
        }
    }

    public static void Swap(List<Box<T>> boxes, List<int> indexes)
    {
        var toBeSwapped = boxes[indexes[0]];
        boxes[indexes[0]] = boxes[indexes[1]];
        boxes[indexes[1]] = toBeSwapped;
    }

    public static int Count(List<T> incomingList, T incomingElement)
    {
        var counter = 0;
        foreach (var item in incomingList)
        {
            if (item.CompareTo(incomingElement) > 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public override string ToString()
    {
        return $"{element.GetType().FullName}: {this.Element}";
    }
}