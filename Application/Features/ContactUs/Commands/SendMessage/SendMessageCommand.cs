//using Application.Features.ContactUs.Rules;
//using Application.Services.Repositories;
//using AutoMapper;
//using Domain.Entities;
//using MediatR;

//namespace Application.Features.ContactUs.Commands.SendMessage;
//public class SendMessageCommand : IRequest<SendedMessageResponse>
//{
//    public string CustomerName { get; set; }
//    public string CustomerEmail { get; set; }
//    public string CustomerPhone { get; set; }
//    public string Subject { get; set; }
//    public string Message { get; set; }
//    public string ReCaptchaKey { get; set; }
//    public string? IPAddress { get; set; }

//    public SendMessageCommand()
//    {
//        CustomerName = string.Empty;
//        CustomerEmail = string.Empty;
//        CustomerPhone = string.Empty;
//        Subject = string.Empty;
//        Message = string.Empty;
//        ReCaptchaKey = string.Empty;
//        IPAddress = string.Empty;
//    }

//    public SendMessageCommand(string customerName, string customerEmail, string customerPhone, string subject, string message, string reCaptchaKey, string ipAddress)
//    {
//        CustomerName = customerName;
//        CustomerEmail = customerEmail;
//        CustomerPhone = customerPhone;
//        Subject = subject;
//        Message = message;
//        ReCaptchaKey = reCaptchaKey;
//        IPAddress = ipAddress;
//    }

//    public class CreateCustomerMessageCommandHandler(
//        ICustomerMessageRepository _customerMessageRepository,
//        CustomerMessageBusinessRules _customerMessageBusinessRules,
//        IMapper _mapper) : IRequestHandler<SendMessageCommand, SendedMessageResponse>
//    {
//        public async Task<SendedMessageResponse> Handle(SendMessageCommand request, CancellationToken cancellationToken)
//        {
//            await _customerMessageBusinessRules.CheckReCaptchaAsync(request.ReCaptchaKey, request.IPAddress!, cancellationToken: cancellationToken);

//            CustomerMessage customerMessage = _mapper.Map<CustomerMessage>(request);

//            CustomerMessage createdCustomerMessage = await _customerMessageRepository.AddAsync(customerMessage);

//            return new(createdCustomerMessage.Id);
//        }
//    }
//}