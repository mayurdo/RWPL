using System;

namespace RWPLEntityModel.ReportView
{
    public class DispatchReportView 
    {
        public long SrNo { get; set; }
        public DateTime Date { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public string Client { get; set; }
        public string VehicalNo { get; set; }
        public string DriverName { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long TotalBundles { get; set; }
        public long TotalQty { get; set; }
    }
}
