namespace Epam.InternshipTasks.Exceptions.Exceptions;

[Serializable]
public class GetAutoByParameterException : Exception
{
    public GetAutoByParameterException()
    {
    }

    public GetAutoByParameterException(string msg) : base(msg)
    {
    }

    public GetAutoByParameterException(string msg, Exception inner) : base(msg, inner)
    {
    }
}