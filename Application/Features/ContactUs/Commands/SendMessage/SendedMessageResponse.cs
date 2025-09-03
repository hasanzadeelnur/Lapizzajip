namespace Application.Features.ContactUs.Commands.SendMessage;

public class SendedMessageResponse
{
    public Guid Id { get; set; }

    public SendedMessageResponse() { }

    public SendedMessageResponse(Guid id)
    {
        Id = id;
    }
}
