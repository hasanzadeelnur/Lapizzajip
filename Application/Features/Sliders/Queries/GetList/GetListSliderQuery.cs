using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Application.Features.Sliders.Queries.GetList;
public class GetListSliderQuery : IRequest<List<GetListSliderResponse>>
{
    public class GetListSliderQueryHandler(ISliderRepository _sliderRepository,
        IMapper _mapper) : IRequestHandler<GetListSliderQuery, List<GetListSliderResponse>>
    {
        public async Task<List<GetListSliderResponse>> Handle(GetListSliderQuery request, CancellationToken cancellationToken)
        {
            List<Slider> sliders = await _sliderRepository.Query().Where(s => s.Status).OrderBy(s => s.Order).ToListAsync(cancellationToken: cancellationToken);

            List<GetListSliderResponse> response = _mapper.Map<List<GetListSliderResponse>>(sliders);

            return response;
        }
    }
}