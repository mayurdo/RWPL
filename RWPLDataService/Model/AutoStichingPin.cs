using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService.Model
{
    public class AutoStichingPin : Entity
    {
        public DateTime Date { get; set; }

        public DateTime InTime { get; set; }

        public DateTime OutTime { get; set; }

        public string Client { get; set; }

        public string BoxCode { get; set; }

        public string BoxName { get; set; }

        public string PinsPerBoxDetail { get; set; }

        public long PinsPerBoxQty { get; set; }

        public long BoxQty { get; set; }

        public long TotalPins { get; set; }

        public string Operator { get; set; }
    }
}
