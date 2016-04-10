using System;
using System.Linq;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class CustomerSummaryDataService
    {
        public ResultResponse<CustomerSummary> Get(CustomerSummarySearchRequest request)
        {
            var response = new ResultResponse<CustomerSummary>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<CustomerSummary>()
                        .Where(x =>  x.CompanyName.Contains(request.CustomerName))
                        .OrderBy(x => x.CompanyName);

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalCustomer = queryable.Count();

                        response.ReportSummary = string.Format("Total Customer : {0}", totalCustomer);
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