using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetListSpeciality;
public class GetListSpecialityProdcutQuery : IRequest<GetListResponse<GetListSpecialityProductDto>>
{

    public class GetListSpecialityProdcutQueryHandler(IProductRepository _productRepository, IMapper _mapper) : IRequestHandler<GetListSpecialityProdcutQuery, GetListResponse<GetListSpecialityProductDto>>
    {
        public async Task<GetListResponse<GetListSpecialityProductDto>> Handle(GetListSpecialityProdcutQuery request, CancellationToken cancellationToken)
        {
            Paginate<Product> products = await _productRepository.GetListAsync(
                predicate: p => p.Status,
                orderBy: o => o.OrderBy(p => p.SpecialOrder).ThenByDescending(p=>p.UpdatedDate),
                index: 0,
                size: 3,
                cancellationToken: cancellationToken);

            GetListResponse<GetListSpecialityProductDto> response = _mapper.Map<GetListResponse<GetListSpecialityProductDto>>(products);

            return response;
        }
    }
}