using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Application.Services.Repositories.Translations;

public interface IProductTranslationRepository : IAsyncRepository<ProductTranslation, Guid>, IRepository<ProductTranslation, Guid>
{
}