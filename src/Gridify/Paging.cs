using System.Collections.Generic;
using System.Linq;

namespace Gridify;

public class Paging<T>
{

   public Paging()
   {
      Data = Enumerable.Empty<T>();
   }
   public void Deconstruct(out int count, out IEnumerable<T> data)
   {
      count = Count;
      data = Data;
   }

   public Paging(int count, IEnumerable<T> data)
   {
      Count = count;
      Data = data;
   }
   public int Count { get; set; }
   public IEnumerable<T> Data { get; set; }
}

public class CursorPaging<T>
{

   public CursorPaging()
   {
      Data = Enumerable.Empty<T>();
   }
   public void Deconstruct(out string cursor, out IEnumerable<T> data)
   {
      cursor = Cursor;
      data = Data;
   }

   public CursorPaging(string cursor, IEnumerable<T> data)
   {
      Cursor = cursor;
      Data = data;
   }
   public string Cursor { get; set; }
   public IEnumerable<T> Data { get; set; }
}
