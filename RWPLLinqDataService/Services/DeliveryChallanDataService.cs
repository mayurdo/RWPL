using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.ReportView;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class DeliveryChallanDataService : BaseDataService<DeliveryChallan>,
        IReportService<DispatchReportView, DispatchSearchRequest,DispatchReportPageRequest>,
        IEntryService<DeliveryChallan,DispatchEntryPageRequest>
    {

        public ResultResponse<DispatchReportView> Get(DispatchSearchRequest request)
        {
            throw new NotImplementedException();
        }

        public ResultResponse<DispatchReportPageRequest> GetReportPageData()
        {
            throw new NotImplementedException();
        }

        public ResultResponse<DispatchEntryPageRequest> GetEntryPageData()
        {
            throw new NotImplementedException();
        }

        public virtual ResultResponse<DeliveryChallan> Save(DeliveryChallan entity)
        {
            var response = new ResultResponse<DeliveryChallan>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var finacialYearData =
                        rwplDb.GetTable<DeliveryChallan>().Where(x => x.FinacialYear == entity.FinacialYear);

                    entity.DeliveryChallanNo = (finacialYearData.Any() ? finacialYearData.Max(x => x.DeliveryChallanNo) + 1 : 1);

                    rwplDb.GetTable<DeliveryChallan>().InsertOnSubmit(entity);

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

    }
}
