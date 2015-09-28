using System.Collections.Generic;

namespace RWPLEntityModel.PageDataRequest
{
    public class BundlingM1ReportPageRequest 
    {
        public List<string> Client { get; set; }

        public List<string> BoxCode { get; set; }

        public List<string> BoxName { get; set; }

        public List<string> Operator { get; set; } 
    }
}