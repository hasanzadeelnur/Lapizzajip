using Application.Services.Repositories.Translations;
using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Persistence.Contexts;

namespace Persistence.Repositories.Translations;

public class ContactUsTranslationRepository(BaseDbContext _context) : EfRepositoryBase<ContactUsTranslation, Guid, BaseDbContext>(_context), IContactUsTranslationRepository
{
}
