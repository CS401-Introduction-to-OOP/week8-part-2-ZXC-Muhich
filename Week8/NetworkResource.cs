namespace Week8;
using System;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("Network is open: " + Name);
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("Network is closed: " + Name);
    }

    public void Dispose()
    {
        Close();
        Console.WriteLine("Network disposed: " + Name);
    }
}