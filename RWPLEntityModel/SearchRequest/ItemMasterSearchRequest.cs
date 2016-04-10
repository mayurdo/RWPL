namespace RWPLEntityModel.SearchRequest
{
    public class ItemMasterSearchRequest : ReportRequest
    {
        public string ItemType { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public string CustomerName { get; set; }

        public string DrawingNo { get; set; }

        public string NoofPly { get; set; }

        public string SheetSizeDeckle { get; set; }

    }
}