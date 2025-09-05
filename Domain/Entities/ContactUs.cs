using Core.Persistence.Repositories;
using Domain.Entities.Translations;

namespace Domain.Entities;
public class ContactUs : Entity<Guid>
{
    public string MapX { get; set; }
    public string MapY { get; set; }
    public string Phones { get; set; }
    public string Emails { get; set; }
    public string TikTokAddress { get; set; }
    public string FacebookAddress { get; set; }
    public string LinkedinAddress { get; set; }
    public string InstagramAddress { get; set; }
    public string WhatsappNumber { get; set; }
    public string KakaoTalk { get; set; }

    public virtual ICollection<ContactUsTranslation> Translations { get; set; }

    public ContactUs()
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
        KakaoTalk = string.Empty;
        Translations = [];
    }

    public ContactUs(
        Guid id, 
        string officeMapX, 
        string officeMapY, 
        string phones, 
        string emails, 
        string tikTokAddress, 
        string facebookAddress, 
        string linkedinAddress, 
        string instagramAddress, 
        string whatsappNumber,
        string kakaoTalk) : this()
    {
        Id = id;
        MapX = officeMapX;
        MapY = officeMapY;
        Phones = phones;
        Emails = emails;
        TikTokAddress = tikTokAddress;
        FacebookAddress = facebookAddress;
        LinkedinAddress = linkedinAddress;
        InstagramAddress = instagramAddress;
        WhatsappNumber = whatsappNumber;
        KakaoTalk = kakaoTalk;
    }
}
