using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class ServiceRepository(BaseDbContext _context) : EfRepositoryBase<Service, Guid, BaseDbContext>(_context), IServiceRepository
{
}
