using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class ContactUsRepository(BaseDbContext _context) : EfRepositoryBase<ContactUs, Guid, BaseDbContext>(_context), IContactUsRepository
{
}
