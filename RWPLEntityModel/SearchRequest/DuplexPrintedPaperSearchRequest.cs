using System;

namespace RWPLEntityModel.SearchRequest
{
    public class DuplexPrintedPaperSearchRequest : ReportRequest
    {
        public string CustomerName { get; set; }

        public string ItemName { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

    }
}