using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Application.Services.Repositories.Translations;

public interface ISliderTranslationRepository : IAsyncRepository<SliderTranslation, Guid>, IRepository<SliderTranslation, Guid>
{
}
