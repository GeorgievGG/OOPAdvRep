public interface IListyIterator<T>
{
    bool HasNext();
    bool Move();
    void Print();
}