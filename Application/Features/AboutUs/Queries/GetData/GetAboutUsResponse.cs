namespace Application.Features.AboutUs.Queries.GetData;

public class GetAboutUsResponse
{
    public Guid Id { get; set; }
    public string FirstImagePath { get; set; }
    public string SecondImagePath { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Thumbnail { get; set; }
    public string YoutubeLink { get; set; }
    public string InstagramUserId { get; set; }
    public string AccessToken { get; set; }

    public GetAboutUsResponse()
    {
        FirstImagePath = string.Empty;
        SecondImagePath = string.Empty;
        Title = string.Empty;
        Body = string.Empty;
        Thumbnail = string.Empty;
        YoutubeLink = string.Empty;
        InstagramUserId = string.Empty;
        AccessToken = string.Empty;
    }

    public GetAboutUsResponse(Guid id, string firstImagePath, string secondImagePath, string title, string body, string thumbnail, string youtubeLink, string userId, string accessToken)
    {
        Id = id;
        FirstImagePath = firstImagePath;
        SecondImagePath = secondImagePath;
        Title = title;
        Body = body;
        Thumbnail = thumbnail;
        YoutubeLink = youtubeLink;
        InstagramUserId = userId;
        AccessToken = accessToken;
    }
}
