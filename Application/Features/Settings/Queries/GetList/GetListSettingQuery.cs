using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Settings.Queries.GetList;
public class GetListSettingQuery : IRequest<Dictionary<string, string>>
{
    public class GetListSettingQueryHandler(ISettingRepository _settingRepository) : IRequestHandler<GetListSettingQuery, Dictionary<string, string>>
    {
        public async Task<Dictionary<string, string>> Handle(GetListSettingQuery request, CancellationToken cancellationToken)
        {
            Dictionary<string, string> response = await _settingRepository.Query().AsNoTracking().ToDictionaryAsync(x => x.Key ?? "", x => x.Value ?? "", cancellationToken: cancellationToken);

            return response;
        }
    }
}