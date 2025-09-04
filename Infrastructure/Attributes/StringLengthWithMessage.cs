using Infrastructure.Resources;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Attributes;
internal class StringLengthWithMessage : StringLengthAttribute
{
    public StringLengthWithMessage(int maximumLength) : base(maximumLength)
    {
        ErrorMessageResourceName = "Required";
        ErrorMessageResourceType = typeof(SharedResource);
    }
}
