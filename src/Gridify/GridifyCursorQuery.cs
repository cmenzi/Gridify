namespace Gridify
{
   public class GridifyCursorQuery : IGridifyCursorQuery
   {
      public GridifyCursorQuery()
      {
      }
      public GridifyCursorQuery(string? cursor, int pageSize, string filter, string? orderBy = null)
      {
         Cursor = cursor;
         PageSize = pageSize;
         OrderBy = orderBy;
         Filter = filter;
      }

      public int PageSize { get; set; }
      public string? OrderBy { get; set; }
      public string? Filter { get; set; }
      public string? Cursor { get; set; }
   }
}
