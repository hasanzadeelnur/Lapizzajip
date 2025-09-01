using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetList;
public class GetListProductQuery : IRequest<GetListResponse<GetListProductDto>>
{
    public PageRequest PageRequest { get; set; }

    public GetListProductQuery()
    {
        PageRequest = null!;
    }

    public GetListProductQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest;
    }

    public class GetListProductQueryHandler(IProductRepository _productRepository, IMapper _mapper) : IRequestHandler<GetListProductQuery, GetListResponse<GetListProductDto>>
    {
        public async Task<GetListResponse<GetListProductDto>> Handle(GetListProductQuery request, CancellationToken cancellationToken)
        {
            Paginate<Product> products = await _productRepository.GetListAsync(
                predicate: p => p.Status,
                orderBy: o => o.OrderBy(p => p.Order),
                cancellationToken: cancellationToken);

            GetListResponse<GetListProductDto> response = _mapper.Map<GetListResponse<GetListProductDto>>(products);

            return response;
        }
    }
}
