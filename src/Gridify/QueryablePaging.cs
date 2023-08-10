using System.Linq;

namespace Gridify;

public class QueryablePaging<T>
{

   public QueryablePaging(int count, IQueryable<T> query)
   {
      Count = count;
      Query = query;
   }
   public void Deconstruct(out int count, out IQueryable<T> query)
   {
      count = Count;
      query = Query;
   }
   public int Count { get; }
   public IQueryable<T> Query { get; }
}

public class QueryableCursorPaging<T>
{
   public QueryableCursorPaging(string cursor, IQueryable<T> query)
   {
      Cursor = cursor;
      Query = query;
   }
   public void Deconstruct(out string cursor, out IQueryable<T> query)
   {
      cursor = Cursor;
      query = Query;
   }
   public string Cursor { get; }
   public IQueryable<T> Query { get; }
}
