using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService.Model
{
    public class BundlingM1 : Entity
    {
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string Client { get; set; }

        public string BoxCode { get; set; }

        public string BoxName { get; set; }

        public string BundleUnit { get; set; }

        public long BundleQty { get; set; }

        public long BoxQty { get; set; }

        public string Operator { get; set; }

    }
}
