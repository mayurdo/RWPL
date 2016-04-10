using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using RWPLEntityModel;

namespace RWPLLinqDataService
{
    public class BaseDataService<TEntity> : MaxIdDataService<TEntity>
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

        public virtual ResultResponse<TEntity> SaveList(List<TEntity> entityList)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    rwplDb.GetTable<TEntity>().InsertAllOnSubmit(entityList);

                    rwplDb.SubmitChanges();
                    
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

        public virtual ResultResponse<TEntity> Save(TEntity entity)
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

    public class MaxIdDataService<TEntity>
         where TEntity : class,IEntity
    {
        public ResultResponse<TEntity> GetMaxId()
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    response.ReportSummary = rwplDb.GetTable<TEntity>().Any()
                                                    ? (rwplDb.GetTable<TEntity>().Max(x => x.SrNo) + 1).ToString(CultureInfo.InvariantCulture)
                                                    : "1";
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
