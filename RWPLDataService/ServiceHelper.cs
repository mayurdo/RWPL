using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService
{
    public class ServiceHelper
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

    }
}
