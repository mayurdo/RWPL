using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
   public class BundlingM1DataService : BaseDataService<BundlingM1>,
       IReportService<BundlingM1, BundlingM1SearchRequest,BundlingM1ReportPageRequest>,
       IEntryService<BundlingM1,BundlingM1EntryPageRequest>
   {
        public ResultResponse<BundlingM1> Get(BundlingM1SearchRequest request)
        {
            var response = new ResultResponse<BundlingM1>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<BundlingM1>()
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
                        var totalBunddle = queryable.Select(x => x.BundleQty).Sum();

                        response.ReportSummary = string.Format("Total Client : {0}, Total Qty : {1}, Total Bunddle : {2}",
                                                                                                totalClient, totalQty, totalBunddle);
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

        public ResultResponse<BundlingM1ReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<BundlingM1ReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<BundlingM1>();

                    response.Object = new BundlingM1ReportPageRequest
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

        public ResultResponse<BundlingM1EntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<BundlingM1EntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    //var queryable = rwplDb.Set<BundlingM1>();

                    //response.Object = new BundlingM1EntryPageRequest()
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
