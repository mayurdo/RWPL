using System;

namespace RWPLEntityModel.SearchRequest
{
    public class InwardMasterSearchRequest : ReportRequest
    {
        public string ReelNo { get; set; }

        public string Mill { get; set; }

        public string BF { get; set; }

        public string GSM { get; set; }

        public string Size { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}