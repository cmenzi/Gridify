namespace Gridify;

public interface IGridifyCursorPagination : IGridifyOrdering
{
   int Limit { get; set; }

   string? Cursor { get; set; }
}
