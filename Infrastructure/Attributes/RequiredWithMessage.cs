using Infrastructure.Resources;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Attributes;
public class RequiredWithMessage : RequiredAttribute
{
    public RequiredWithMessage()
    {
        ErrorMessageResourceName = "Required";
        ErrorMessageResourceType = typeof(SharedResource);
    }
}
