namespace RWPLEntityModel
{
    public class ReportRequest
    {
        public ReportRequest()
        {
            PageNo = 1;
            PageSize = 20;
        }

        public int PageNo { get; set; }

        public int PageSize { get; set; }
    }
}
