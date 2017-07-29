public class Tuple<T, T2>
{
    public Tuple(T item1, T2 item2)
    {
        this.Item1 = item1;
        this.Item2 = item2;
    }

    private T item1;
    private T2 item2;

    public T Item1
    {
        get
        {
            return item1;
        }

        set
        {
            item1 = value;
        }
    }

    public T2 Item2
    {
        get
        {
            return item2;
        }

        set
        {
            item2 = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2}";
    }
}