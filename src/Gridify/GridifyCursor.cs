namespace Gridify;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal sealed class GridifyCursor
{
   public GridifyCursor(string cursor)
   {
      if (string.IsNullOrEmpty(cursor))
         throw new ArgumentNullException(nameof(cursor));

      var decodedBytes = Convert.FromBase64String(cursor);
      var decodedCursor = Encoding.UTF8.GetString(decodedBytes);
      var arr = decodedCursor.Split('\0');

      OrderBy = arr[0];
      NextToken = arr[1];
   }

   public string OrderBy { get; }

   public string NextToken { get; }
}
