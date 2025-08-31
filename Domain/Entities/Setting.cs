using Core.Persistence.Repositories;
using Domain.Enums;

namespace Domain.Entities;
public class Setting : Entity<Guid>
{
    public string Key { get; set; }
    public string Value { get; set; }
    public SettingType Type { get; set; }
    public string? Comment { get; set; }

    public Setting()
    {
        Key = string.Empty;
        Value = string.Empty;
        Comment = string.Empty;
    }

    public Setting(Guid id,string key, string value, SettingType type, string? comment)
    {
        Id = id;
        Key = key;
        Value = value;
        Type = type;
        Comment = comment;
    }
}
