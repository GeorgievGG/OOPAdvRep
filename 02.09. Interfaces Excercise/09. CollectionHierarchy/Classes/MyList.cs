public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
{
    public int Used => this.list.Count;
    public override T Remove()
    {
        var toBeReturned = base.list[0];
        list.RemoveAt(0);
        return toBeReturned;
    }
}