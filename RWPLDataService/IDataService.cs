using RWPLEntityModel;

namespace RWPLDataService
{
    public interface IDataService<TEntity, TView, TSearchRequest, TReportPageRequest, TEntryPageRequest>
    {
        ResultResponse<TEntity> GetEntityById(long srNo);

        ResultResponse<TEntity> Save(TEntity entity);

        ResultResponse<TEntity> Edit(TEntity entity);

        ResultResponse<TEntity> Delete(long srNo);

        ResultResponse<TView> Get(TSearchRequest request);

        ResultResponse<TReportPageRequest> GetReportPageData();

        ResultResponse<TEntryPageRequest> GetEntryPageData();
    }
}