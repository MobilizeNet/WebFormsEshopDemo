using System;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogItemHiLoGenerator
   {
       private const int HiLoIncrement = 10;

      [Intercepted]
      private int sequenceId { get; set; } = -1;

      [Intercepted]
      private int remainningLoIds { get; set; } = 0;

      [Intercepted]
      private object sequenceLock { get; set; } = new object();

      public int GetNextSequenceValue(CatalogDBContext db)
      {
          lock (sequenceLock)
          {
              if (remainningLoIds == 0)
              {
                  var rawQuery = db.Database.SqlQuery<Int64>("SELECT NEXT VALUE FOR catalog_hilo;");
                  sequenceId = (int)rawQuery.Single();
                  remainningLoIds = HiLoIncrement - 1;
                  return sequenceId;
              }
              else
              {
                  remainningLoIds--;
                  return ++sequenceId;
              }
          }
      }

   }
}