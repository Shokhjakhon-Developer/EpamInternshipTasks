namespace Epam.InternshipTasks.Exceptions.Exceptions;

    [Serializable]
    public class AddException : Exception
    {
        public AddException()
        {
        }

        public AddException(string msg) : base(msg)
        {
        }

        public AddException(string msg, Exception inner) : base(msg, inner)
        {
        }
    }
