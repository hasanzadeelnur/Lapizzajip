using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProductCategories.Queries.GetList;
public class GetListProductCategoryQuery : IRequest<GetListResponse<GetListProductCategoryDto>>
{
    public PageRequest PageRequest { get; set; }

    public GetListProductCategoryQuery()
    {
        PageRequest = null!;
    }

    public GetListProductCategoryQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }

    public class enuGetListProductCategoryQueryHandler(IProductCategoryRepository _productCategoryRepository, IMapper _mapper) : IRequestHandler<GetListProductCategoryQuery, GetListResponse<GetListProductCategoryDto>>
    {
        public async Task<GetListResponse<GetListProductCategoryDto>> Handle(GetListProductCategoryQuery request, CancellationToken cancellationToken)
        {
            Paginate<ProductCategory> productCategories = await _productCategoryRepository.GetListAsync(
                predicate: p => p.Status,
                orderBy: o => o.OrderBy(p => p.Order),
                cancellationToken: cancellationToken);

            GetListResponse<GetListProductCategoryDto> response = _mapper.Map<GetListResponse<GetListProductCategoryDto>>(productCategories);

            return response;
        }
    }
}
