using Microsoft.Extensions.Localization;
using System.Reflection;

namespace Infrastructure.Resources
{
    /// <summary>
    ///     Constructor of shared localizer.
    /// </summary>
    /// <param name="localizerFactory"></param>
    public class SharedLocalizer(
        IStringLocalizerFactory localizerFactory) : ISharedLocalizer
    {
        private readonly IStringLocalizerFactory _localizerFactory = localizerFactory;

        /// <summary>
        ///     Function to get localization strings.
        /// </summary>
        /// <returns>Returns IStringLocalizer.</returns>
        public IStringLocalizer GetLocalizer()
        {
            var type = typeof(SharedResource).GetTypeInfo().Assembly.FullName!;
            var assemblyName = new AssemblyName(type!);

            return _localizerFactory.Create("SharedResource", assemblyName.Name!);
        }
    }
}
