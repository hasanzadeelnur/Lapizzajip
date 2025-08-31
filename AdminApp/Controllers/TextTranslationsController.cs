using AdminApp.Controllers.Base;
using Domain.Entities;
using Persistence.Contexts;

namespace AdminApp.Controllers;

public class TextTranslationsController(BaseDbContext db) : BaseController<TextTranslation>(db)
{
}
