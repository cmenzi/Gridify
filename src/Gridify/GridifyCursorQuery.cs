namespace Gridify;

public class GridifyCursorQuery : GridifyQuery, IGridifyCursorQuery
{
   public GridifyCursorQuery()
   {
   }

   public GridifyCursorQuery(int pageSize, string? orderBy = null)
     : base(null, orderBy)
   {
      PageSize = pageSize;
   }

   public GridifyCursorQuery(string? cursor, int pageSize, string? orderBy = null)
      : base(null, orderBy)
   {
      Cursor = cursor;
      PageSize = pageSize;
   }

   public GridifyCursorQuery(string? cursor, int pageSize, string filter, string? orderBy = null)
      : base(filter, orderBy)
   {
      Cursor = cursor;
      PageSize = pageSize;
   }

   public int PageSize { get; set; }

   public string? Cursor { get; set; }
}
