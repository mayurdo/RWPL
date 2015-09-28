using System;

namespace RWPLEntityModel.SearchRequest
{
    public class AutoStichingPinSearchRequest : ReportRequest
    {
        public string Client { get; set; }

        public string BoxCode { get; set; }

        public string BoxName { get; set; }

        public string Operator { get; set; }

        public bool IsSearchByDate { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }
    }
}
