namespace Application.Features.ContactUs.Queries.GetData;

public class GetContactUsResponse
{
    public Guid Id { get; set; }
    public string OfficeMapX { get; set; }
    public string OfficeMapY { get; set; }
    public string Address { get; set; }
    public string Phones { get; set; }
    public string Emails { get; set; }
    public string Description { get; set; }
    public string WorkingHours { get; set; }
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeys { get; set; }
    public string TikTokAddress { get; set; }
    public string FacebookAddress { get; set; }
    public string LinkedinAddress { get; set; }
    public string InstagramAddress { get; set; }
    public string WhatsappNumber { get; set; }

    public GetContactUsResponse()
    {
        OfficeMapX = string.Empty;
        OfficeMapY = string.Empty;
        Address = string.Empty;
        Phones = string.Empty;
        Emails = string.Empty;
        WorkingHours = string.Empty;
        TikTokAddress = string.Empty;
        FacebookAddress = string.Empty;
        LinkedinAddress = string.Empty;
        InstagramAddress = string.Empty;
        WhatsappNumber = string.Empty;
    }

    public GetContactUsResponse(Guid id, string officeMapX, string officeMapY, string address, string phones, string emails, string workingHours, string tikTokAddress, string facebookAddress, string linkedinAddress, string instagramAddress, string whatsappNumber)
    {
        Id = id;
        OfficeMapX = officeMapX;
        OfficeMapY = officeMapY;
        Address = address;
        Phones = phones;
        Emails = emails;
        WorkingHours = workingHours;
        TikTokAddress = tikTokAddress;
        FacebookAddress = facebookAddress;
        LinkedinAddress = linkedinAddress;
        InstagramAddress = instagramAddress;
        WhatsappNumber = whatsappNumber;
    }
}
