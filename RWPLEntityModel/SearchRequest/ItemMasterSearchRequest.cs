namespace RWPLEntityModel.SearchRequest
{
    public class ItemMasterSearchRequest : ReportRequest
    {
        public string ItemType { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }
    }
}