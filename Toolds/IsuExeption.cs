namespace Isu.Exceptions;

public class IsuExeption : Exception
{
    public IsuExeption() { }

    public IsuExeption(string message)

        : base($"Invalid group name ")
    {
    }

    public IsuExeption(string message, Exception newExeption)
        : base(message, newExeption)
    {
    }
}