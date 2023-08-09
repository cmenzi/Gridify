namespace Gridify;

public class GridifyQuery : IGridifyQuery
{
   public GridifyQuery()
   {
   }

   public GridifyQuery(string filter, string? orderBy = null)
   {
      OrderBy = orderBy;
      Filter = filter;
   }

   public string? OrderBy { get; set; }
   public string? Filter { get; set; }
}

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

public class GridifyCursorQuery : GridifyQuery, IGridifyCursorPagination
{
   public GridifyCursorQuery()
   {
   }

   public GridifyCursorQuery(int limit, string cursor, string filter, string? orderBy = null)
      : base(filter, orderBy)
   {
      Limit = limit;
      Cursor = cursor;
   }

   public int Limit { get; set; }

   public string? Cursor { get; set; }
}
