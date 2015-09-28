using System;

namespace RWPLEntityModel.SearchRequest
{
    public class DispatchSearchRequest : ReportRequest
    {
        public string ItemType { get; set; }

        public string Client { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public string VehicalNo { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}
