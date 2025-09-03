using Application.Services.Repositories.Translations;
using Core.Persistence.Repositories;
using Domain.Entities.Translations;
using Persistence.Contexts;

namespace Persistence.Repositories.Translations;

public class SliderTranslationRepository(BaseDbContext _context) : EfRepositoryBase<SliderTranslation, Guid, BaseDbContext>(_context), ISliderTranslationRepository
{
}
