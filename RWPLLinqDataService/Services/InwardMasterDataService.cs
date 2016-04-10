using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class InwardMasterDataService : BaseDataService<InwardMaster>,
        IReportService<InwardMasterView, InwardMasterSearchRequest, InwardMasterReportPageRequest>,
        IEntryService<InwardMaster, StockMasterEntryPageRequest>
    {
        public ResultResponse<InwardMasterView> Get(InwardMasterSearchRequest request)
        {
            var response = new ResultResponse<InwardMasterView>();
            try
            {
                //var bfList = ServiceHelper.GetLongFromString(request.BF);
                var gsmList = ServiceHelper.GetLongFromString(request.GSM);
                var size = string.IsNullOrEmpty(request.Size) ? 0 : Convert.ToDecimal(request.Size);
                var sizeRange1 = size - 1;
                var sizeRange2 = size + 2;

                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<InwardMasterView>()
                        .Where(x => x.ReelNo.Contains(request.ReelNo)
                                    && x.Mill.Contains(request.Mill)
                                    && ((request.BF == "") || x.BF == request.BF)
                                    //&& ((request.BF == "") || bfList.Contains(x.BF))
                                    && ((request.GSM == "") || gsmList.Contains(x.GSM))
                                    && ((request.Size == "") ||
                                          (request.Size != "" && (x.Size >= sizeRange1 && x.Size <= sizeRange2)))
                                    && (!request.IsSearchByDate ||
                                        (x.Date >= request.FromDate.Date && x.Date <= request.ToDate.Date))
                                    && !x.IsDeleted
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
                        var totalReel = queryable.Select(x => x.ReelNo).Distinct().Count();
                        var totalReceived = queryable.Select(x => x.Received).Sum();
                        var totalConsumption = queryable.Select(x => x.Consumption).Sum();
                        var totalBalance = queryable.Select(x => x.Balance).Sum();
                        response.ReportSummary = string.Format("Total Reel : {0}, Total Received : {1}, Total Consumption : {2}, Total Balance : {3}"
                                                                            , totalReel, totalReceived, totalConsumption, totalBalance);
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

        public ResultResponse<StockMasterEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<StockMasterEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<InwardMaster>();

                    response.Object = new StockMasterEntryPageRequest
                    {
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
