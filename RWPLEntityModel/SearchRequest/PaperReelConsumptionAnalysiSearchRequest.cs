using System;

namespace RWPLEntityModel.SearchRequest
{
    public class PaperReelConsumptionAnalysiSearchRequest : ReportRequest
    {
        public string Machine { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}