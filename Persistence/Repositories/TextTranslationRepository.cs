using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class TextTranslationRepository(BaseDbContext _context) : EfRepositoryBase<TextTranslation, int, BaseDbContext>(_context), ITextTranslationRepository
{
}