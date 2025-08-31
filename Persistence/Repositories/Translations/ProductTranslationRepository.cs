using Application.Services.Repositories.Translations;
using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Persistence.Contexts;

namespace Persistence.Repositories.Translations;

internal class ProductTranslationRepository(BaseDbContext _context) : EfRepositoryBase<ProductTranslation, Guid, BaseDbContext>(_context), IProductTranslationRepository
{
}