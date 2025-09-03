using Application.Services.Repositories;
using AutoMapper;
using MediatR;

namespace Application.Features.ContactUs.Queries.GetData;
public class GetContactUsQuery : IRequest<GetContactUsResponse>
{
    public class GetContactUsQueryHandler(
        IContactUsRepository _contactUsRepository,
        IMapper _mapper) : IRequestHandler<GetContactUsQuery, GetContactUsResponse>
    {
        public async Task<GetContactUsResponse> Handle(GetContactUsQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.ContactUs contactUs = await _contactUsRepository.GetAsync(predicate: cu => true, cancellationToken: cancellationToken);

            GetContactUsResponse response = _mapper.Map<GetContactUsResponse>(contactUs);

            return response;
        }
    }
}