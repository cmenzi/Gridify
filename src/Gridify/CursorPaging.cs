namespace Gridify
{
   using System.Collections.Generic;
   using System.Linq;

   public class CursorPaging<T> : Paging<T>
   {
      public CursorPaging()
      {
      }

      public void Deconstruct(out string cursor, out int count, out IEnumerable<T> data)
      {
         cursor = Cursor;
         count = Count;
         data = Data;
      }

      public CursorPaging(string cursor, int count, IEnumerable<T> data)
         : base(count, data)
      {
         Cursor = cursor;
      }

      public string Cursor { get; set; }
   }
}
