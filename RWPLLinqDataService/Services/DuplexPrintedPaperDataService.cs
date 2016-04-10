using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class DuplexPrintedPaperDataService : BaseDataService<DuplexPrintedPaper>,
        IReportService<DuplexPrintedPaper, DuplexPrintedPaperSearchRequest,DuplexPrintedPaperReportPageRequest>,
        IEntryService<DuplexPrintedPaper,DuplexPrintedPaperEntryPageRequest>
    {
        public ResultResponse<DuplexPrintedPaper> Get(DuplexPrintedPaperSearchRequest request)
        {
            var response = new ResultResponse<DuplexPrintedPaper>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<DuplexPrintedPaper>()
                        .Where(x => x.CustomerName.Contains(request.CustomerName)
                                    && x.ItemName.Contains(request.ItemName)
                                    && (!request.IsSearchByDate ||
                                        (x.Date >= request.FromDate.Date && x.Date <= request.ToDate.Date))
                                    && !x.IsDeleted
                        )
                        .OrderBy(x => x.SrNo);

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalCustomer = queryable.Select(x => x.CustomerName).Distinct().Count();
                        var totalItem = queryable.Select(x => x.ItemName).Count();

                        response.ReportSummary = string.Format("Total Customer : {0}, Total Item : {1}", totalCustomer, totalItem);
                    }

                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Exception = ex;
            }

            return response;
        }

        public ResultResponse<DuplexPrintedPaperReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<DuplexPrintedPaperReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = new DuplexPrintedPaperReportPageRequest
                    {
                        CustomerName = rwplDb.CustomerMasters.Select(x => x.CustomerName).Distinct().OrderBy(x => x).ToList(),
                        ItemName = rwplDb.ItemMasters.Select(x => x.ItemName).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                    };

                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.IsSuccess = false;
            }

            return response;
        }

        public ResultResponse<DuplexPrintedPaperEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<DuplexPrintedPaperEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = new DuplexPrintedPaperEntryPageRequest
                    {
                        CustomerName = rwplDb.CustomerMasters.Select(x => x.CustomerName).Distinct().OrderBy(x => x).ToList(),
                        ItemName = rwplDb.ItemMasters.Select(x => x.ItemName).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                    };

                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                response.Exception = ex;
                response.IsSuccess = false;
            }

            return response;
        }

    }
}
