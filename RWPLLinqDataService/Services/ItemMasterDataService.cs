using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class ItemMasterDataService : BaseDataService<ItemMaster>,
        IReportService<ItemMaster, ItemMasterSearchRequest, ItemMasterReportPageRequest>,
        IEntryService<ItemMaster, ItemMasterEntryPageRequest>
    {
        public ResultResponse<ItemMaster> Get(ItemMasterSearchRequest request)
        {
            var response = new ResultResponse<ItemMaster>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<ItemMaster>()
                        .Where(x => x.BoxType.Contains(request.ItemType)
                                    && x.ItemCode.Contains(request.ItemCode)
                                    && x.ItemName.Contains(request.ItemName)
                                    && x.CustomerName.Contains(request.CustomerName)
                                    && x.DrawingNo.Contains(request.DrawingNo)
                                    && x.NoofPly.Contains(request.NoofPly)
                                    && !x.IsDeleted
                        )
                        .OrderBy(x => x.ItemName);

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalItem = queryable.Count();

                        response.ReportSummary = string.Format("Total Items : {0}", totalItem);
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

        public ResultResponse<ItemMasterReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<ItemMasterReportPageRequest>();

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

        public ResultResponse<ItemMasterEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<ItemMasterEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    //var queryable = rwplDb.Set<ItemMaster>();

                    //response.Object = new ItemMasterEntryPageRequest()
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
