public class Threeuple<T, T2, T3> : Tuple<T, T2>
{
    public Threeuple(T item1, T2 item2, T3 item3) : base(item1, item2)
    {
        this.Item3 = item3;
    }

    private T3 item3;

    public T3 Item3
    {
        get
        {
            return item3;
        }

        set
        {
            item3 = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
    }
}