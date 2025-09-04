using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ICustomerMessageRepository : IAsyncRepository<CustomerMessage, Guid>, IRepository<CustomerMessage, Guid>
{
}
