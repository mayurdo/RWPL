using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWPLDataService.Model
{
    public class PaperReelConsumption : Entity
    {
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public long BF { get; set; }

        public long GSM { get; set; }

        public decimal Size { get; set; }

        public string LF { get; set; }

        public string ReelNo { get; set; }

        public string Mill { get; set; }

        public string Grade { get; set; }

        public decimal Weight { get; set; }

        public decimal Consumption { get; set; }

        public decimal Balance { get; set; }
    }
}
