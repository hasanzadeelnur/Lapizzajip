namespace Infrastructure.Dtos.ContactUs;
public class ContactUsCommandDto
{
    public Guid? Id { get; set; }
    public string MapX { get; set; }
    public string MapY { get; set; }
    public string Phones { get; set; }
    public string Emails { get; set; }
    public string TikTokAddress { get; set; }
    public string FacebookAddress { get; set; }
    public string LinkedinAddress { get; set; }
    public string InstagramAddress { get; set; }
    public string WhatsappNumber { get; set; }

    public virtual ICollection<ContactUsTranslationCommandDto> Translations { get; set; }

    public ContactUsCommandDto()
    {
        MapX = string.Empty;
        MapY = string.Empty;
        Phones = string.Empty;
        Emails = string.Empty;
        TikTokAddress = string.Empty;
        FacebookAddress = string.Empty;
        LinkedinAddress = string.Empty;
        InstagramAddress = string.Empty;
        WhatsappNumber = string.Empty;
        Translations = [];
    }

    public ContactUsCommandDto(
        Guid? id,
        string mapX,
        string mapY,
        string phones,
        string emails,
        string tikTokAddress,
        string facebookAddress,
        string linkedinAddress,
        string instagramAddress,
        string whatsappNumber,
        ICollection<ContactUsTranslationCommandDto> translations)
    {
        Id = id;
        MapX = mapX;
        MapY = mapY;
        Phones = phones;
        Emails = emails;
        TikTokAddress = tikTokAddress;
        FacebookAddress = facebookAddress;
        LinkedinAddress = linkedinAddress;
        InstagramAddress = instagramAddress;
        WhatsappNumber = whatsappNumber;
        Translations = translations;
    }
}