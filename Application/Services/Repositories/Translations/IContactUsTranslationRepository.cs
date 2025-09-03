using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Application.Services.Repositories.Translations;

public interface IContactUsTranslationRepository : IAsyncRepository<ContactUsTranslation, Guid>, IRepository<ContactUsTranslation, Guid>
{
}
