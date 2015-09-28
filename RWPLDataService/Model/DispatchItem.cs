using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService.Model
{
    public class DispatchItem : Entity
    {
        public string ItemType { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public string QtyPerBundle { get; set; }

        public long TotalBundles { get; set; }

        public long TotalQty { get; set; }

        public Dispatch Dispatch { get; set; }
    }
}
