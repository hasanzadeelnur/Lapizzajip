using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Sliders.Queries.GetList;
public class GetListSliderQuery : IRequest<List<GetListSliderDto>>
{
    public class GetListSliderQueryHandler(ISliderRepository _sliderRepository,
        IMapper _mapper) : IRequestHandler<GetListSliderQuery, List<GetListSliderDto>>
    {
        public async Task<List<GetListSliderDto>> Handle(GetListSliderQuery request, CancellationToken cancellationToken)
        {
            List<Slider> sliders = await _sliderRepository.Query().Include(s => s.Images).Where(s => s.Status).OrderBy(s => s.Order).ToListAsync(cancellationToken: cancellationToken);

            List<GetListSliderDto> response = _mapper.Map<List<GetListSliderDto>>(sliders);

            return response;
        }
    }
}