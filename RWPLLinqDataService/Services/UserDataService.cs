using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class UserDataService : BaseDataService<User>,
        IReportService<UserReportView, UserSearchRequest, UserReportPageRequest>,
        IEntryService<User, UserEntryPageRequest>
    {
        public ResultResponse<UserReportView> Get(UserSearchRequest request)
        {
            var response = new ResultResponse<UserReportView>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);

                    var queryable = (from user in rwplDb.Users
                                     join userAccessPage in rwplDb.UserAccessPages on user equals userAccessPage.User
                                     where user.UserName.Contains(request.UserName)
                                           && userAccessPage.PageName.Contains(request.PageName)
                                         //&& (!request.IsSearchByDate ||
                                         //    (dispatch.Date >= request.FromDate && dispatch.Date <= request.ToDate))
                                           && !user.IsDeleted
                                           && !userAccessPage.IsDeleted
                                     orderby userAccessPage.SrNo
                                     select new
                                     {
                                         user.SrNo,
                                         user.UserName,
                                         userAccessPage.PageName,
                                         userAccessPage.View,
                                         userAccessPage.Add,
                                         userAccessPage.Edit,
                                         userAccessPage.Delete
                                     })
                        .Skip(skipRecord)
                        .Take(request.PageSize)
                        .AsEnumerable()
                        .Select(x => new UserReportView()
                        {
                            SrNo = x.SrNo,
                            UserName = x.UserName,
                            PageName = x.PageName,
                            View = x.View,
                            Add = x.Add,
                            Edit = x.Edit,
                            Delete = x.Delete
                        });

                    var userReportView = queryable as UserReportView[] ?? queryable.ToArray();

                    response.PageData = userReportView.ToList();
                    response.TotalItem = userReportView.Count();

                    var totalUser = userReportView.Select(x => x.UserName).Distinct().Count();

                    response.ReportSummary = string.Format("Total User : {0}", totalUser);

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

        public ResultResponse<UserReportPageRequest> GetReportPageData()
        {
            //var response = new ResultResponse<UserReportPageRequest>();

            //try
            //{
            //    using (var rwplDb = new RWPLContext())
            //    {
            //        var queryableUser = rwplDb.Set<User>();

            //        var queryableAccessPage = rwplDb.Set<UserAccessPage>();

            //        response.Object = new UserReportPageRequest()
            //        {
            //            ItemType = new List<string>() { "Box", "Insertion", "Plate" },
            //            Client = queryableDispatch.Select(x => x.Client).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
            //            VehicalNo = queryableDispatch.Select(x => x.VehicalNo).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),

            //            ItemCode = queryableDispatchItem.Select(x => x.Code).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
            //            ItemName = queryableDispatchItem.Select(x => x.Name).Distinct().Where(x => x != string.Empty).OrderBy(x => x).ToList(),
            //        };

            //        response.IsSuccess = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    response.Exception = ex;
            //    response.IsSuccess = false;
            //}

            //return response;

            throw new NotImplementedException();
        }

        public ResultResponse<UserEntryPageRequest> GetEntryPageData()
        {
            throw new NotImplementedException();
        }

        public override ResultResponse<User> GetEntityById(long srNo)
        {
            var response = new ResultResponse<User>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = rwplDb.GetTable<User>().IncludeTable(x => x.UserAccessPages).SingleOrDefault(x => x.SrNo == srNo);
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

        public override ResultResponse<User> Edit(User entity)
        {
            var response = new ResultResponse<User>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    rwplDb.GetTable<User>().Attach(entity, true);

                    foreach (var item in entity.UserAccessPages)
                    {
                        if (item.SrNo != 0)
                        {
                            rwplDb.GetTable<UserAccessPage>().Attach(item, true);
                            continue;
                        }

                        rwplDb.GetTable<UserAccessPage>().InsertOnSubmit(item);
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

        public ResultResponse<User> GetUser(string userName, string password)
        {
            var response = new ResultResponse<User>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = rwplDb.GetTable<User>()
                                            .IncludeTable<User>(x => x.UserAccessPages)
                                            .SingleOrDefault(x => x.UserName == userName && x.Password == password);//.Include(x => x.UserAccessPageses)
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
