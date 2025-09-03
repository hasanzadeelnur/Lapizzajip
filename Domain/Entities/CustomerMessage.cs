using Core.Persistence.Repositories;

namespace Domain.Entities;
public class CustomerMessage : Entity<Guid>
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }

    public CustomerMessage()
    {
        CustomerName = string.Empty;
        CustomerEmail = string.Empty;
        CustomerPhone = string.Empty;
        Subject = string.Empty;
        Message = string.Empty;
    }

    public CustomerMessage(Guid id, string customerName, string customerEmail, string customerPhone, string subject, string message)
    {
        Id = id;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        Subject = subject;
        Message = message;
    }
}
