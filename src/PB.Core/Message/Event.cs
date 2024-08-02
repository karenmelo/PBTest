using MediatR;

namespace PB.Core.Message;

public class Event : Message, INotification
{
    public DateTime Timestamp { get; private set; }

    protected Event()
    {
        Timestamp = DateTime.Now;
    }
}
