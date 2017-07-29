public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        var toBeReturned = new T[length];
        for (int i = 0; i < length; i++)
        {
            toBeReturned[i] = item;
        }
        return toBeReturned;
    }
}