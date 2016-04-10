using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class StockMasterReportDataService :
     IReportService<StockMasterReport,InwardMasterSearchRequest,InwardMasterReportPageRequest>
    {
        public ResultResponse<StockMasterReport> Get(InwardMasterSearchRequest request)
        {
            var response = new ResultResponse<StockMasterReport>();
            try
            {
                //var bfList = ServiceHelper.GetLongFromString(request.BF);
                var gsmList = ServiceHelper.GetLongFromString(request.GSM);
                var size = string.IsNullOrEmpty(request.Size) ? 0 : Convert.ToDecimal(request.Size);
                var sizeRange1 = size - 1;
                var sizeRange2 = size + 2;

                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<StockMasterReport>()
                        .Where(x => ((request.BF == "") ||  x.BF==request.BF)
                                    && ((request.GSM == "") || gsmList.Contains(x.GSM))
                                    && ((request.Size == "") ||
                                          (request.Size != "" && (x.Size >= sizeRange1 && x.Size <= sizeRange2)))
                        )
                        .OrderBy(x => x.SrNo);

                    if (request.ShowAllData)
                    {
                        response.PageData = queryable.ToList();
                        response.IsSuccess = true;
                        return response;
                    }

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);
                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalNoOfReels = queryable.Select(x => x.NoOfReels).Distinct().Count();
                        var totalReceived = queryable.Select(x => x.Received).Sum();
                        var totalConsumption = queryable.Select(x => x.Consumption).Sum();
                        var totalBalance = queryable.Select(x => x.Balance).Sum();
                        response.ReportSummary = string.Format("Total No of Reel : {0}, Total Received : {1}, Total Consumption : {2}, Total Balance : {3}"
                                                                            , totalNoOfReels, totalReceived, totalConsumption, totalBalance);
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

        public ResultResponse<InwardMasterReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<InwardMasterReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<InwardMaster>();

                    response.Object = new InwardMasterReportPageRequest
                    {
                        ReelNo = queryable.Select(x => x.ReelNo).Distinct().OrderBy(x => x).ToList(),
                        Mill = queryable.Select(x => x.Mill).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
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

