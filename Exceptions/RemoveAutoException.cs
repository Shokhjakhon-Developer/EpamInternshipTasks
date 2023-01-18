namespace Epam.InternshipTasks.Exceptions.Exceptions;

[Serializable]
public class RemoveAutoException : Exception
{
    public RemoveAutoException()
    {
    }

    public RemoveAutoException(string msg) : base(msg)
    {
    }

    public RemoveAutoException(string msg, Exception inner) : base(msg, inner)
    {
    }
}