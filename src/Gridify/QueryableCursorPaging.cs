namespace Gridify
{
   using System.Linq;

   public class QueryableCursorPaging<T> : QueryablePaging<T>
   {
      public QueryableCursorPaging(string cursor, int count, IQueryable<T> query)
         : base(count, query)
      {
         Cursor = cursor;
      }

      public void Deconstruct(out string cursor, out int count, out IQueryable<T> query)
      {
         cursor = Cursor;
         count = Count;
         query = Query;
      }

      public string Cursor { get; }
   }
}
