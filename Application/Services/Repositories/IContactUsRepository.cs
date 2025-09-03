using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IContactUsRepository : IAsyncRepository<ContactUs, Guid>, IRepository<ContactUs, Guid>
{
}
