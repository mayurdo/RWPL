using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RWPLEntityModel.PageDataRequest
{
    public class RotaryReportPageRequest
    {
        public List<string> Client { get; set; }

        public List<string> BoxCode { get; set; }

        public List<string> BoxName { get; set; }

        public List<string> Operator { get; set; }
    }
}
