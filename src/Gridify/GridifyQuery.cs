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
