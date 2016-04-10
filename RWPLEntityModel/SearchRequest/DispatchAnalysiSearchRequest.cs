using System;

namespace RWPLEntityModel.SearchRequest
{
    public class DispatchAnalysiSearchRequest : ReportRequest
    {
        public string Client { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}