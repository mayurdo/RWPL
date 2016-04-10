using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWPLDataService.Model;
using RWPLEntityModel;

namespace RWPLDataService
{
    public class BaseDataService<TEntity>
         where TEntity : Entity
    {
        public ResultResponse<TEntity> GetMaxId()
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    response.ReportSummary = rwplDb.Set<TEntity>().Any() ? (rwplDb.Set<TEntity>().Max(x => x.SrNo) + 1).ToString(CultureInfo.InvariantCulture) : "1";
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

        public virtual ResultResponse<TEntity> GetEntityById(long srNo)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    response.Object = rwplDb.Set<TEntity>().Find(srNo);
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
                using (var rwplDb = new RWPLContext())
                {
                    rwplDb.Set<TEntity>().Add(entity);

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

        public virtual ResultResponse<TEntity> Edit(TEntity entity)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    rwplDb.Entry(entity).State = System.Data.Entity.EntityState.Modified;

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

        public ResultResponse<TEntity> Delete(long srNo)
        {
            var response = new ResultResponse<TEntity>();
            try
            {
                using (var rwplDb = new RWPLContext())
                {
                    var entity = rwplDb.Set<TEntity>().Find(srNo);
                    entity.IsDeleted = true;
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
