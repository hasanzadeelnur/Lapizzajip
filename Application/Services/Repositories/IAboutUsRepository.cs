﻿using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IAboutUsRepository : IAsyncRepository<AboutUs, Guid>, IRepository<AboutUs, Guid>
{
}
