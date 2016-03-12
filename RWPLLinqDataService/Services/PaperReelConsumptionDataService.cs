using System;
using System.Linq;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class PaperReelConsumptionDataService : BaseDataService<PaperReelConsumption>,
        IDataService<PaperReelConsumption, PaperReelConsumption, PaperReelConsumptionSearchRequest,
        PaperReelConsumptionReportPageRequest, PaperReelConsumptionEntryPageRequest>
    {
        public ResultResponse<PaperReelConsumption> Get(PaperReelConsumptionSearchRequest request)
        {
            var response = new ResultResponse<PaperReelConsumption>();
            try
            {
                //var bfList = ServiceHelper.GetLongFromString(request.BF);
                var gsmList = ServiceHelper.GetLongFromString(request.GSM);

                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<PaperReelConsumption>()
                        .Where(x => x.ReelNo.Contains(request.ReelNo)
                                    && x.Mill.Contains(request.Mill)
                                    && x.BF.Contains(request.BF)
                                    //&& ((request.BF=="") || bfList.Contains(x.BF))
                                    && ((request.GSM=="") || gsmList.Contains(x.GSM))
                                    && x.Machine.Contains(request.Machine)
                                    && (!request.IsSearchByDate ||
                                        (x.Date >= request.FromDate.Date && x.Date <= request.ToDate.Date))
                                    && !x.IsDeleted
                        )
                        .OrderBy(x => x.Date);

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
                        var totalWeight = queryable.Select(x => x.Weight).Sum();
                        var totalConsumption = queryable.Select(x => x.Consumption).Sum();
                        var totalBalance = queryable.Select(x => x.Balance).Sum();

                        response.ReportSummary = string.Format("Total Reel : {0}, Total Weight : {1}, Total Consumption : {2}, Total Balance: {3}",
                                                                                                totalReel, totalWeight, totalConsumption,totalBalance);
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

        public ResultResponse<PaperReelConsumptionReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<PaperReelConsumptionReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<PaperReelConsumption>();

                    response.Object = new PaperReelConsumptionReportPageRequest
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

        public ResultResponse<PaperReelConsumptionEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<PaperReelConsumptionEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<PaperReelConsumption>();

                    response.Object = new PaperReelConsumptionEntryPageRequest
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