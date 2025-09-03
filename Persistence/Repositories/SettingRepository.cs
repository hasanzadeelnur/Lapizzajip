using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class SettingRepository(BaseDbContext _context) : EfRepositoryBase<Setting, Guid, BaseDbContext>(_context), ISettingRepository
{
}
