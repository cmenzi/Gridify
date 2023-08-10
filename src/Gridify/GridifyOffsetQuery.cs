namespace Gridify;

public class GridifyOffsetQuery : GridifyQuery, IGridifyOffsetQuery
{
   public GridifyOffsetQuery()
   {
   }

   public GridifyOffsetQuery(int page, int pageSize, string filter, string? orderBy = null)
      : base(filter, orderBy)
   {
      Page = page;
      PageSize = pageSize;
   }

   public int Page { get; set; }
   public int PageSize { get; set; }
}
