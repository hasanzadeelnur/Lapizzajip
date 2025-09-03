using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ISliderImageRepository : IAsyncRepository<SliderImage, Guid>, IRepository<SliderImage, Guid>
{
}
