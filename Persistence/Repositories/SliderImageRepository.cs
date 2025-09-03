using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class SliderImageRepository(BaseDbContext _context) : EfRepositoryBase<SliderImage, Guid, BaseDbContext>(_context), ISliderImageRepository
{
}
