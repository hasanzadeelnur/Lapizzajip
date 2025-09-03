using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using System.Globalization;

namespace Application.Features.AboutUs.Queries.GetData;
public class GetAboutUsQuery : IRequest<GetAboutUsResponse>
{
    public class GetAboutUsQueryHandler(
        IAboutUsRepository _aboutUsRepository,
        IMapper _mapper) : IRequestHandler<GetAboutUsQuery, GetAboutUsResponse>
    {
        public async Task<GetAboutUsResponse> Handle(GetAboutUsQuery request, CancellationToken cancellationToken)
        {
            Domain.Entities.AboutUs aboutUs = await _aboutUsRepository.GetAsync(predicate: a => a.LanguageKey == CultureInfo.CurrentCulture.Name, cancellationToken: cancellationToken);

            GetAboutUsResponse response = _mapper.Map<GetAboutUsResponse>(aboutUs);

            return response;
        }
    }
}