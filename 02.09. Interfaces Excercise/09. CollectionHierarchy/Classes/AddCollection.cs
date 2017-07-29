using System.Collections.Generic;

public class AddCollection<T> : IAddCollection<T>
{
    public AddCollection()
    {
        this.list = new List<T>();
    }
    protected List<T> list;

    public IReadOnlyList<T> List
    {
        get
        {
            return list.AsReadOnly();
        }
    }

    public virtual int Add(T element)
    {
        list.Add(element);
        return list.Count - 1;
    }
}