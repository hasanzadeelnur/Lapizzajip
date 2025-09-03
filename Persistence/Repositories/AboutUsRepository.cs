using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;
internal class AboutUsRepository(BaseDbContext _context) : EfRepositoryBase<AboutUs, Guid, BaseDbContext>(_context), IAboutUsRepository
{
}