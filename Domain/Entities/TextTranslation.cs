using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;
public class TextTranslation : Entity<int>
{
    public string Key { get; set; }
    public string Value { get; set; }
    public SettingType Type { get; set; }
    public string LanguageKey { get; set; }

    public TextTranslation()
    {
        Key = string.Empty;
        Value = string.Empty;
        LanguageKey = string.Empty;
        Type = SettingType.Text;
        CreatedDate = DateTime.Now;
        UpdatedDate = null!;
        DeletedDate = null!;
    }

    public TextTranslation(int id,string key, string value, string languageKey, SettingType settingType = SettingType.Text)
    {
        Id= id;
        Key = key;
        Value = value;
        LanguageKey = languageKey;
        Type = settingType;
    }
}