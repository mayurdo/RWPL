using System;
using System.Linq;
using RWPLEntityModel;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class DispatchAnalysiDataService
    {
        public ResultResponse<DispatchAnalysi> Get(DispatchAnalysiSearchRequest request)
        {
            var response = new ResultResponse<DispatchAnalysi>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    var queryable = rwplDb.GetTable<DispatchAnalysi>()
                        .Where(x => x.Client.Contains(request.Client)
                                    && x.ItemCode.Contains(request.ItemCode)
                                    && x.ItemName.Contains(request.ItemName)
                        //&& (!request.IsSearchByDate ||
                        //    (dispatch.Date >= request.FromDate.Date && dispatch.Date <= request.ToDate.Date))
                        )
                        .OrderBy(x => (x.Year*100) + x.Month);


                    response.PageData = queryable.Skip(skipRecord)
                        .Take(request.PageSize)
                        .ToList();

                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalClient = queryable.Select(x => x.Client).Distinct().Count();
                        var totalQtyDispatch = queryable.Select(x => x.TotalDispatchQty).Sum();

                        response.ReportSummary =
                            string.Format("Total Client : {0}, Total dispatch Qty : {1}", totalClient, totalQtyDispatch);
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
    }
}