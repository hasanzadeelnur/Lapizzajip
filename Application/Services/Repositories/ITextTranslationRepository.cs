using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ITextTranslationRepository : IAsyncRepository<TextTranslation, int>, IRepository<TextTranslation, int>
{
}
