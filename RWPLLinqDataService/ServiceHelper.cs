using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using RWPLEntityModel;

namespace RWPLLinqDataService
{
    public static class ServiceHelper
    {
        public static List<long> GetLongFromString(string value)
        {
            List<long> result = new List<long>();

            string[] arr = value.Split(',');

            foreach (string a in arr)
            {
                string[] adesh = a.Split('-');
                try
                {
                    long MinValue = Convert.ToInt64(adesh[0]);
                    long MaxValue = Convert.ToInt64(adesh[adesh.Length - 1]);
                    while (MaxValue >= MinValue)
                    {
                        result.Add(MinValue);
                        MinValue++;
                    }
                }
                catch
                {
                    continue;
                }
            }

            return result;
        }

        public static Table<TEntity> IncludeTable<TEntity>(this Table<TEntity> table, Expression<Func<TEntity, object>> expression)
          where TEntity : class, IEntity
        {
            var options = new DataLoadOptions();
            options.LoadWith<TEntity>(expression);
            table.Context.LoadOptions = options;

            return table;
        }
    }
}
