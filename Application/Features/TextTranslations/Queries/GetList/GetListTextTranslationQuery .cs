using Application.Services.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Application.Features.TextTranslations.Queries.GetList;
public class GetListTextTranslationQuery : IRequest<Dictionary<string, string>>
{
    public class GetListTextTranslationQueryHandler(ITextTranslationRepository _textTranslationRepository) : IRequestHandler<GetListTextTranslationQuery, Dictionary<string, string>>
    {
        public async Task<Dictionary<string, string>> Handle(GetListTextTranslationQuery request, CancellationToken cancellationToken)
        {
            Dictionary<string, string> response = await _textTranslationRepository.Query().Where(x => x.LanguageKey == CultureInfo.CurrentCulture.Name).AsNoTracking().ToDictionaryAsync(x => x.Key ?? "", x => x.Value ?? "", cancellationToken: cancellationToken);

            return response;
        }
    }
}