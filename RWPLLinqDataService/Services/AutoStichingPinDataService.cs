using System;
using System.Linq;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class AutoStichingPinDataService : BaseDataService<AutoStichingPin>,
        IReportService<AutoStichingPin, AutoStichingPinSearchRequest, AutoStichingPinReportPageRequest>,
        IEntryService<AutoStichingPin, AutoStichingPinEntryPageRequest>
    {
        public ResultResponse<AutoStichingPin> Get(AutoStichingPinSearchRequest request)
        {
            var response = new ResultResponse<AutoStichingPin>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<AutoStichingPin>()
                                          .Where(x => x.Client.Contains(request.Client)
                                                    && x.BoxCode.Contains(request.BoxCode)
                                                    && x.BoxName.Contains(request.BoxName)
                                                    && x.Operator.Contains(request.Operator)
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
                        var totalClient = queryable.Select(x => x.Client).Distinct().Count();
                        var totalQty = queryable.Select(x => x.BoxQty).Sum();
                        var totalPins = queryable.Select(x => x.TotalPins).Sum();

                        response.ReportSummary = string.Format("Total Client : {0}, Total Box Qty : {1}, Total Pins : {2}",
                                                                                totalClient, totalQty, totalPins);
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

        public ResultResponse<AutoStichingPinReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<AutoStichingPinReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<AutoStichingPin>();

                    response.Object = new AutoStichingPinReportPageRequest()
                    {
                        Client = queryable.Select(x => x.Client).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        BoxCode = queryable.Select(x => x.BoxCode).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        BoxName = queryable.Select(x => x.BoxName).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        Operator = queryable.Select(x => x.Operator).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
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

        public ResultResponse<AutoStichingPinEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<AutoStichingPinEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    //var queryable = rwplDb.Set<AutoStichingPin>();

                    //response.Object = new AutoStichingPinEntryPageRequest()
                    //{
                    //    ReelNo = queryable.Select(x => x.ReelNo).Distinct().OrderBy(x => x).ToList(),
                    //    Mill = queryable.Select(x => x.Mill).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                    //};

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
