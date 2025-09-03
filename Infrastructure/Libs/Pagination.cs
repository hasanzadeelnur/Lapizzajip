using Infrastructure.Dtos.Common;

namespace Infrastructure.Libs;
public class Pagination<T>
{
    public static PaginateDto<T> PaginationMethod(int page, int take, int count)
    {
        int pageCount = (int)Math.Ceiling(count / (decimal)take);
        if (page <= 5 || pageCount <= 9)
        {
            if (pageCount <= 9)
                return new PaginateDto<T> () { StartPage = 0, PageCount = pageCount, Index = page, EndPage = pageCount - 1 };
            else
                return new PaginateDto<T>() { StartPage = 0, PageCount = pageCount, Index = page, EndPage = 9 };
        }
        else
        {
            if (page > pageCount - 5)
                return new PaginateDto<T>() { StartPage = page - 9, PageCount = pageCount, Index = page, EndPage = pageCount - 1 };
            else
                return new PaginateDto<T>() { StartPage = page - 5, PageCount = pageCount, Index = page, EndPage = page + 4 };
        }
    }
}
