namespace PB.Core.DomainObject;

public class DomainException : Exception
{
    public DomainException() { }

    public DomainException(string messagem) : base(messagem) { }

    public DomainException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
}
