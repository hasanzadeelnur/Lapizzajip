using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Dtos.ContactUs;

public class ContactUsTranslationCommandDto
{
    public Guid? Id { get; set; }
    public Guid ContactUsId { get; set; }
    public string Address { get; set; }
    public string WorkingHours { get; set; }
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeys { get; set; }
    [Required]
    public string LanguageKey { get; set; }

    public ContactUsTranslationCommandDto()
    {
        Address = string.Empty;
        WorkingHours = string.Empty;
        MetaTitle = string.Empty;
        MetaDescription = string.Empty;
        MetaKeys = string.Empty;
        LanguageKey = string.Empty;
    }

    public ContactUsTranslationCommandDto(
        Guid? id,
        Guid contactUsId,
        string address,
        string workingHours,
        string metaTitle,
        string metaDescription,
        string metaKeys,
        string languageKey)
    {
        Id = id;
        ContactUsId = contactUsId;
        Address = address;
        WorkingHours = workingHours;
        MetaTitle = metaTitle;
        MetaDescription = metaDescription;
        MetaKeys = metaKeys;
        LanguageKey = languageKey;
    }
}