namespace Application.Features.ProductCategories.Queries.GetList;

public class GetListProductCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }

    public GetListProductCategoryDto()
    {
        Name = string.Empty;
    }

    public GetListProductCategoryDto(Guid id, string name, int order, bool status, DateTime createdDate)
    {
        Id = id;
        Name = name;
        Order = order;
        Status = status;
        CreatedDate = createdDate;
    }
}