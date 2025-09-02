using Core.Persistence.Repositories;

namespace Domain.Entities;
public class AboutUs : LanguageEntity
{
    public string FirstImagePath { get; set; }
    public string FirstBody { get; set; }
    public string SecondImagePath { get; set; }
    public string SecondBody { get; set; }
    public string StoryBody { get; set; }
    public string MetaTitle { get; set; }
    public string MetaDescription { get; set; }
    public string MetaKeys { get; set; }

    public AboutUs()
    {
        FirstImagePath = string.Empty;
        FirstBody = string.Empty;
        SecondImagePath = string.Empty;
        SecondBody = string.Empty;
        StoryBody = string.Empty;
        MetaTitle = string.Empty;
        MetaDescription = string.Empty;
        MetaKeys = string.Empty;
    }

    public AboutUs(Guid id, string firstImagePath, string firstBody, string secondImagePath, string secondBody, string storyBody, string metaTitle, string metaDescription, string metaKeys, string languageKey)
    {
        Id = id;
        FirstImagePath = firstImagePath;
        FirstBody = firstBody;
        SecondImagePath = secondImagePath;
        SecondBody = secondBody;
        StoryBody = storyBody;
        MetaTitle = metaTitle;
        MetaDescription = metaDescription;
        MetaKeys = metaKeys;
        LanguageKey = languageKey;
    }
}
