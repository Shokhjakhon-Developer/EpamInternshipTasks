namespace Epam.InternshipTasks.Exceptions.Exceptions;

[Serializable]
public class UpdateAutoException : Exception
{
    public UpdateAutoException()
    {
    }

    public UpdateAutoException(string msg) : base(msg)
    {
    }

    public UpdateAutoException(string msg, Exception inner) : base(msg, inner)
    {
    }
}