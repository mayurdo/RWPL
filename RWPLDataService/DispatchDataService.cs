using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RWPLDataService.Model;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;

namespace RWPLDataService
{
    public class DispatchDataService : BaseDataService<Dispatch>,
        IDataService<Dispatch, DispatchReportView, DispatchSearchRequest,
        DispatchReportPageRequest, DispatchEntryPageRequest>
    {
        public ResultResponse<DispatchReportView> Get(DispatchSearchRequest request)
        {
            var response = new ResultResponse<DispatchReportView>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    var queryable = (from dispatch in rwplDb.Dispatchs
                                     join dispatchItem in rwplDb.DispatchItems on dispatch equals dispatchItem.Dispatch
                                     where dispatchItem.ItemType.Contains(request.ItemType)
                                           && dispatch.Client.Contains(request.Client)
                                           && dispatchItem.ItemCode.Contains(request.ItemCode)
                                           && dispatchItem.ItemName.Contains(request.ItemName)
                                           && dispatch.VehicalNo.Contains(request.VehicalNo)
                                           && (!request.IsSearchByDate ||
                                               (dispatch.Date >= request.FromDate && dispatch.Date <= request.ToDate))
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
                                     })
                        .Skip(skipRecord)
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
                        });

                    var viewDispatches = queryable as DispatchReportView[] ?? queryable.ToArray();

                    response.PageData = viewDispatches.ToList();
                    response.TotalItem = viewDispatches.Count();

                    var totalClient = viewDispatches.Select(x => x.Client).Distinct().Count();
                    var totalQty = viewDispatches.Select(x => x.TotalQty).Sum();
                    var totalBunddle = viewDispatches.Select(x => x.TotalBundles).Sum();

                    response.ReportSummary = string.Format("Total Client : {0}, Total Qty : {1}, Total Bunddle : {2}",
                                                                            totalClient, totalQty, totalBunddle);

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
                using (var rwplDb = new RWPLContext())
                {
                    var queryableDispatch = rwplDb.Set<Dispatch>();

                    var queryableDispatchItem = rwplDb.Set<DispatchItem>();

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
                using (var rwplDb = new RWPLContext())
                {
                    var queryableDispatch = rwplDb.Set<Dispatch>();

                    var queryableDispatchItem = rwplDb.Set<DispatchItem>();

                    response.Object = new DispatchEntryPageRequest()
                    {
                        ItemType = new List<string>() { "Box", "Insertion", "Plate" },
                        Client = queryableDispatch.Select(x => x.Client).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        VehicalNo = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
                        DriverName = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
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

        public override ResultResponse<Dispatch> GetEntityById(long srNo)
        {
            var response = new ResultResponse<Dispatch>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    response.Object = rwplDb.Set<Dispatch>().Include(x => x.DispatchItems).SingleOrDefault(x => x.SrNo == srNo);
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
                using (var rwplDb = new RWPLContext())
                {
                    rwplDb.Entry(entity).State = EntityState.Modified;

                    foreach (var item in entity.DispatchItems)
                    {
                        rwplDb.Entry(item).State = (item.SrNo != 0) ? EntityState.Modified : EntityState.Added;
                    }


                    rwplDb.SaveChanges();

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
    }
}
