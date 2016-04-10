using RWPLEntityModel;

namespace RWPLLinqDataService
{
    public interface IReportService<TView, TSearchRequest, TReportPageRequest>
    {
        ResultResponse<TView> Get(TSearchRequest request);

        ResultResponse<TReportPageRequest> GetReportPageData();
    }

    public interface IEntryService<TEntity, TEntryPageRequest>
    {
        ResultResponse<TEntity> GetEntityById(long srNo);

        ResultResponse<TEntity> Save(TEntity entity);

        ResultResponse<TEntity> Edit(TEntity entity);

        ResultResponse<TEntity> Delete(long srNo, string deletedBy, string deleteReason);

        ResultResponse<TEntryPageRequest> GetEntryPageData();
    }
}