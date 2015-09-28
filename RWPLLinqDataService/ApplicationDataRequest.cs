using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWPLLinqDataService
{
    public class ApplicationDataRequest
    {
        public List<ItemMaster> Items { get; set; }

        public List<CustomerMaster> Customers { get; set; }

    }
}
