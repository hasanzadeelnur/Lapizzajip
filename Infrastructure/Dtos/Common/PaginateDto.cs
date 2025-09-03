namespace Infrastructure.Dtos.Common;
public class PaginateDto<TItems>
{
    public int StartPage { get; set; }
    public int Index { get; set; }
    public int PageCount { get; set; }
    public int EndPage { get; set; }
    public bool HasPrevious { get; set; }
    public bool HasNext { get; set; }
    public ICollection<TItems> Items { get; set; } = [];

    public PaginateDto()
    {
        Items = [];
    }
}
