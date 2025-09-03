using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Application.Features.Services.Queries.GetList;
public class GetListServiceQuery : IRequest<List<GetListServiceResponse>>
{
    public class GetListServiceQueryHandler(IServiceRepository _sliderRepository,
        IMapper _mapper) : IRequestHandler<GetListServiceQuery, List<GetListServiceResponse>>
    {
        public async Task<List<GetListServiceResponse>> Handle(GetListServiceQuery request, CancellationToken cancellationToken)
        {
            List<Service> services = await _sliderRepository.Query().Where(s => s.Status && s.LanguageKey == CultureInfo.CurrentCulture.Name).OrderBy(s => s.Order).Take(4).ToListAsync(cancellationToken: cancellationToken);

            List<GetListServiceResponse> response = _mapper.Map<List<GetListServiceResponse>>(services);

            return response;
        }
    }
}