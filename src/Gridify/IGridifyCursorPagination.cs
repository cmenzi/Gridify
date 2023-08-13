namespace Gridify;

public interface IGridifyCursorPagination : IGridifyOrdering
{
   string? Cursor { get; set; }

   int PageSize { get; set; }
}
