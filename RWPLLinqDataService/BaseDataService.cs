using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;

namespace RWPLLinqDataService
{
    public class BaseDataService<TEntity>
         where TEntity : class,IEntity
    {
        public virtual ResultResponse<TEntity> GetEntityById(long srNo)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.Object = rwplDb.GetTable<TEntity>().AsEnumerable().SingleOrDefault(x => x.SrNo == srNo);
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

        public ResultResponse<TEntity> Save(TEntity entity)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    rwplDb.GetTable<TEntity>().InsertOnSubmit(entity);

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

        public virtual ResultResponse<TEntity> Edit(TEntity entity)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    rwplDb.GetTable<TEntity>().Attach(entity,true);

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

        public ResultResponse<TEntity> Delete(long srNo, string deletedBy, string deleteReason)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var entity = rwplDb.GetTable<TEntity>().AsEnumerable().Single(x => x.SrNo == srNo);

                    entity.DeletedBy = deletedBy;
                    entity.DeletedDate = DateTime.Now;
                    entity.DeleteReason = deleteReason;
                    entity.IsDeleted = true;

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
