using Application.Services.Repositories;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Products.Queries.GetListSpecialityForCategory;
public class GetListSpecialityForCategoryProductQuery : IRequest<GetListSpecialityForCategoryProductResponse>
{

    public class GetListSpecialityForCategoryProductQueryHandler(IProductRepository _productRepository, IProductCategoryRepository _productCategoryRepository, IMapper _mapper) : IRequestHandler<GetListSpecialityForCategoryProductQuery, GetListSpecialityForCategoryProductResponse>
    {
        public async Task<GetListSpecialityForCategoryProductResponse> Handle(GetListSpecialityForCategoryProductQuery request, CancellationToken cancellationToken)
        {
            GetListSpecialityForCategoryProductResponse response = new();

            Paginate<ProductCategory> productCategories = await _productCategoryRepository.GetListAsync(
                predicate: p => p.Status,
                orderBy: p => p.OrderBy(o => o.SpecialOrder).ThenByDescending(o => o.UpdatedDate),
                index: 0,
                size: 8,
                cancellationToken: cancellationToken);
            response.Categories= _mapper.Map<List<GetListSpecialityForCategoryProductCategoryDto>>(productCategories.Items);

            foreach (ProductCategory productCategory in productCategories.Items)
            {
                GetListSpecialityForCategoryProductResponse getListSpecialityForCategoryProduct = _mapper.Map<GetListSpecialityForCategoryProductResponse>(productCategory);
                List<Product> products = await _productRepository.Query().Skip(0).Take(9).Where(p => p.Status && p.CategoryId == productCategory.Id).OrderBy(o => o.SpecialOrder).ThenByDescending(o => o.UpdatedDate).ToListAsync(cancellationToken: cancellationToken);
                getListSpecialityForCategoryProduct.Products.AddRange(_mapper.Map<List<GetListSpecialityForCategoryProductDto>>(products));
            }

            return response;
        }
    }
}