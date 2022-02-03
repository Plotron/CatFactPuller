using System.Runtime.Serialization;

namespace CatFactPuller.Logic;

public class CatFactMissingException : Exception
{
    public CatFactMissingException()
    {
    }

    protected CatFactMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public CatFactMissingException(string? message) : base(message)
    {
    }

    public CatFactMissingException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}