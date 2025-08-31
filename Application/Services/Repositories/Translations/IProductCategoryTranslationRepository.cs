using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Application.Services.Repositories.Translations;

public interface IProductCategoryTranslationRepository : IAsyncRepository<ProductCategoryTranslation, Guid>, IRepository<ProductCategoryTranslation, Guid>
{
}
