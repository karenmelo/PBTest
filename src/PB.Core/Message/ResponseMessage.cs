using System.ComponentModel.DataAnnotations;

namespace PB.Core.Message;

public class ResponseMessage : Message
{
    public ValidationResult ValidationResult { get; set; }

    public ResponseMessage(ValidationResult validationResult)
    {
        ValidationResult = validationResult;
    }
}
