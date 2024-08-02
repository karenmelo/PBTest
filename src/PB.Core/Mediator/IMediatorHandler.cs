using PB.Core.Message;
using System.ComponentModel.DataAnnotations;

namespace PB.Core.Mediator;

public interface IMediatorHandler
{
    Task PublicarEvento<T>(T evento) where T : Event;
    Task<ValidationResult> EnviarComando<T>(T comando) where T : Command;
}
