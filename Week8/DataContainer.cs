namespace Week8;
using System.Collections.Generic;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public long GetTotalSize()
    {
        long total = 0;

        for (int i = 0; i < _items.Count; i++)
        {
            total += _items[i].GetSize();
        }

        return total;
    }
}