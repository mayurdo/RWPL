using System.Collections.Generic;

namespace RWPLEntityModel.PageDataRequest
{
    public class DispatchEntryPageRequest
    {
        public List<string> ItemType { get; set; }

        public List<string> Client { get; set; }
      
        public List<string> VehicalNo { get; set; }

        public List<string> DriverName { get; set; }

        public List<string> ItemCode { get; set; }

        public List<string> ItemName { get; set; }

    }
}
