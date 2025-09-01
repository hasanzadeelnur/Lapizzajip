using Application.Services.Repositories.Translations;
using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Persistence.Contexts;

namespace Persistence.Repositories.Translations;

public class ProductCategoryTranslationRepository(BaseDbContext _context) : EfRepositoryBase<ProductCategoryTranslation, Guid, BaseDbContext>(_context), IProductCategoryTranslationRepository
{
}