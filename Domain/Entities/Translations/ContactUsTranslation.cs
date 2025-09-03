using Core.Persistence.Repositories;

namespace Domain.Entities.Translations;
public class ContactUsTranslation : LanguageEntity
{
    public Guid ContactUsId { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public string WorkingHours { get; set; }
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeys { get; set; }

    public virtual ContactUs ContactUs { get; set; }

    public ContactUsTranslation()
    {
        Address = string.Empty;
        Description = string.Empty;
        WorkingHours = string.Empty;
        MetaTitle = string.Empty;
        MetaDescription = string.Empty;
        MetaKeys = string.Empty;
        ContactUs = null!;
    }

    public ContactUsTranslation(Guid contactUsId, string address, string description, string workingHours, string metaTitle, string metaDescription, string metaKeys) : this()
    {
        ContactUsId = contactUsId;
        Address = address;
        Description = description;
        WorkingHours = workingHours;
        MetaTitle = metaTitle;
        MetaDescription = metaDescription;
        MetaKeys = metaKeys;
    }
}
