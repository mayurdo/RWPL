using System;
using System.Collections.Generic;

namespace RWPLEntityModel
{
    public class ResultResponse<T>
    {
        public List<T> PageData { get; set; }

        public T Object { get; set; }

        public string ReportSummary { get; set; }

        public long TotalItem { get; set; }

        public bool IsSuccess { get; set; }

        public Exception Exception { get; set; }
    }
}
