using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class ProductCategoryRepository(BaseDbContext _context) : EfRepositoryBase<ProductCategory, Guid, BaseDbContext>(_context), IProductCategoryRepository
{
}
