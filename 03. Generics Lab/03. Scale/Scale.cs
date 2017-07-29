using System;

public class Scale<T> where T : IComparable<T>
{
    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    private T left;
    private T right;

    public T Left
    {
        get
        {
            return left;
        }

        private set
        {
            left = value;
        }
    }

    public T Right
    {
        get
        {
            return right;
        }

        private set
        {
            right = value;
        }
    }

    public T GetHavier()
    {
        var x = left.CompareTo(right);
        if (x > 0)
        {
            return left;
        }
        else if (x < 0)
        {
            return right;
        }
        return default(T);
    }
}