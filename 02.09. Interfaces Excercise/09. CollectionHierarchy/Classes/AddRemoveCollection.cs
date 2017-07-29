public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
{
    public AddRemoveCollection() : base()
    { }

    public override int Add(T element)
    {
        this.list.Insert(0, element);
        return 0;
    }

    public virtual T Remove()
    {
        var toBeReturned = base.list[base.list.Count - 1];
        list.RemoveAt(this.list.Count - 1);
        return toBeReturned;
    }
}