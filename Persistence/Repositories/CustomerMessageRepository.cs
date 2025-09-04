using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class CustomerMessageRepository(BaseDbContext _context) : EfRepositoryBase<CustomerMessage, Guid, BaseDbContext>(_context), ICustomerMessageRepository
{
}
