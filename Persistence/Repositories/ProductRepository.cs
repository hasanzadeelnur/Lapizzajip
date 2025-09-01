using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ProductRepository(BaseDbContext _context) : EfRepositoryBase<Product, Guid, BaseDbContext>(_context), IProductRepository
{
}
