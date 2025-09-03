using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

internal class SliderRepository(BaseDbContext _context) : EfRepositoryBase<Slider, Guid, BaseDbContext>(_context), ISliderRepository
{
}