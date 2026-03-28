namespace Week8;
using System.Collections.Generic;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();

    public void Add(T resource)
    {
        _resources.Add(resource);
    }

    public void OpenAll()
    {
        for (int i = 0; i < _resources.Count; i++)
        {
            _resources[i].Open();
        }
    }

    public void CloseAll()
    {
        for (int i = 0; i < _resources.Count; i++)
        {
            _resources[i].Close();
        }
    }
}