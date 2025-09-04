using Infrastructure.Attributes;
using Infrastructure.Resources;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Dtos.Messages;
public class CreateMessageDto
{
    [RequiredWithMessage]
    [StringLengthWithMessage(100)]
    public string CustomerName { get; set; } = string.Empty;
    [RequiredWithMessage]
    [StringLengthWithMessage(100)]
    [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(SharedResource))]
    public string CustomerEmail { get; set; } = string.Empty;
    [RequiredWithMessage]
    [StringLengthWithMessage(100)]
    public string CustomerPhone { get; set; } = string.Empty;
    [RequiredWithMessage]
    [StringLengthWithMessage(300)]
    public string Subject { get; set; } = string.Empty;
    [RequiredWithMessage]
    [StringLengthWithMessage(1000)]
    public string Message { get; set; } = string.Empty;
    public string ReCaptchaKey { get; set; } = string.Empty;
    public string? IPAddress { get; set; } = string.Empty;
}