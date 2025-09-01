using Microsoft.Extensions.Localization;

namespace Infrastructure.Resources
{
    public interface ISharedLocalizer
    {
        IStringLocalizer GetLocalizer();
    }
}
