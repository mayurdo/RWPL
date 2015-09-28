using System;

namespace RWPLEntityModel.SearchRequest
{
    public class PaperReelConsumptionSearchRequest : ReportRequest
    {
        public string ReelNo { get; set; }

        public string Mill { get; set; }

        public string Grade { get; set; }

        public string BF { get; set; }

        public string GSM { get; set; }

        public string Machine { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

    }
}
