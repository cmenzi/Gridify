namespace Gridify;

public interface IGridifyCursorPagination : IGridifyOrdering
{
   int PageSize { get; set; }

   string? Cursor { get; set; }
}
