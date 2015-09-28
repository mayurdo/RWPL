using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class CustomerMasterDataService : BaseDataService<CustomerMaster>,
       IDataService<CustomerMaster, CustomerMaster, CustomerMasterSearchRequest,
           CustomerMasterReportPageRequest, CustomerMasterEntryPageRequest>
    {
        public ResultResponse<CustomerMaster> Get(CustomerMasterSearchRequest request)
        {
            var response = new ResultResponse<CustomerMaster>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<CustomerMaster>()
                        .Where(x => x.CustomerName.Contains(request.CustomerName)
                                    && !x.IsDeleted
                        )
                        .OrderBy(x => x.CustomerName);

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();
                    response.ReportSummary = string.Format("Total Customers : {0}", response.TotalItem);
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

        public ResultResponse<CustomerMasterReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<CustomerMasterReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
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

        public ResultResponse<CustomerMasterEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<CustomerMasterEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    //var queryable = rwplDb.Set<CustomerMaster>();

                    //response.Object = new CustomerMasterEntryPageRequest()
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
