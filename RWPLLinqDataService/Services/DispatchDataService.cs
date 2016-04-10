using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;

namespace RWPLLinqDataService.Services
{
    public class DispatchDataService : BaseDataService<Dispatch>,
        IReportService<DispatchReportView, DispatchSearchRequest,DispatchReportPageRequest>,
        IEntryService<Dispatch,DispatchEntryPageRequest>
    {
        public ResultResponse<DispatchReportView> Get(DispatchSearchRequest request)
        {
            var response = new ResultResponse<DispatchReportView>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    var queryable = (from dispatch in rwplDb.Dispatches
                                     join dispatchItem in rwplDb.DispatchItems on dispatch equals dispatchItem.Dispatch
                                     where dispatchItem.ItemType.Contains(request.ItemType)
                                           && dispatch.Client.Contains(request.Client)
                                           && dispatchItem.ItemCode.Contains(request.ItemCode)
                                           && dispatchItem.ItemName.Contains(request.ItemName)
                                           && dispatch.VehicalNo.Contains(request.VehicalNo)
                                           && (!request.IsSearchByDate ||
                                               (dispatch.Date >= request.FromDate.Date && dispatch.Date <= request.ToDate.Date))
                                           && !dispatch.IsDeleted
                                           && !dispatchItem.IsDeleted
                                     orderby dispatch.SrNo
                                     select new
                                     {
                                         dispatch.SrNo,
                                         dispatch.Date,
                                         dispatch.InTime,
                                         dispatch.OutTime,
                                         dispatch.Client,
                                         dispatch.VehicalNo,
                                         dispatch.DriverName,
                                         dispatchItem.ItemType,
                                         dispatchItem.ItemCode,
                                         dispatchItem.ItemName,
                                         dispatchItem.TotalBundles,
                                         dispatchItem.TotalQty
                                     });

                    response.PageData = queryable.Skip(skipRecord)
                                                    .Take(request.PageSize)
                                                    .AsEnumerable()
                                                    .Select(x => new DispatchReportView
                                                    {
                                                        SrNo = x.SrNo,
                                                        Date = x.Date,
                                                        InTime = x.InTime,
                                                        OutTime = x.OutTime,
                                                        Client = x.Client,
                                                        VehicalNo = x.VehicalNo,
                                                        DriverName = x.DriverName,
                                                        Type = x.ItemType,
                                                        Code = x.ItemCode,
                                                        Name = x.ItemName,
                                                        TotalBundles = x.TotalBundles,
                                                        TotalQty = x.TotalQty
                                                    }).ToList();

                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalClient = queryable.Select(x => x.Client).Distinct().Count();
                        var totalQty = queryable.Select(x => x.TotalQty).Sum();
                        var totalBunddle = queryable.Select(x => x.TotalBundles).Sum();

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


        public ResultResponse<DispatchReportPageRequest> GetReportPageData()
        {
            var response = new ResultResponse<DispatchReportPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryableDispatch = rwplDb.GetTable<Dispatch>();

                    var queryableDispatchItem = rwplDb.GetTable<DispatchItem>();

                    response.Object = new DispatchReportPageRequest()
                    {
                        ItemType = new List<string>() { "Box", "Insertion", "Plate" },
                        Client = queryableDispatch.Select(x => x.Client).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        VehicalNo = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),

                        ItemCode = queryableDispatchItem.Select(x => x.ItemCode).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        ItemName = queryableDispatchItem.Select(x => x.ItemName).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
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

        public ResultResponse<DispatchEntryPageRequest> GetEntryPageData()
        {
            var response = new ResultResponse<DispatchEntryPageRequest>();

            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryableDispatch = rwplDb.GetTable<Dispatch>();

                    response.Object = new DispatchEntryPageRequest()
                    {
                        ItemType = new List<string>() { "Box", "Insertion", "Plate" },
                        VehicalNo = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        DriverName = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
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

        public override ResultResponse<Dispatch> GetEntityById(long srNo)
        {
            var response = new ResultResponse<Dispatch>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = rwplDb.GetTable<Dispatch>()
                                            .IncludeTable(x => x.DispatchItems)
                                            .SingleOrDefault(x => x.SrNo == srNo);
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



        public override ResultResponse<Dispatch> Edit(Dispatch entity)
        {
            var response = new ResultResponse<Dispatch>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    rwplDb.GetTable<Dispatch>().Attach(entity, true);

                    foreach (var item in entity.DispatchItems)
                    {
                        if (item.SrNo != 0)
                        {
                            rwplDb.GetTable<DispatchItem>().Attach(item, true);
                            continue;
                        }

                        rwplDb.GetTable<DispatchItem>().InsertOnSubmit(item);
                    }

                    rwplDb.SubmitChanges();

                    response.Object = entity;
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

        //protected virtual object GetEntitySet()
        //{
        //    return new EntitySet<DispatchItem>().AddRange();
        //}
    }
}
