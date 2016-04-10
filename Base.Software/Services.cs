using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using RWPLEntityModel;
using RWPLLinqDataService;
using RWPLLinqDataService.Services;

namespace Base.Software
{
    public interface IServices
    {
        ResultResponse<T> GetServiceResponse<T>(ReportRequest request);
        ResultResponse<T> GetReportPageDataServiceResponse<T>();
        ResultResponse<T> GetEntryPageDataServiceResponse<T>();
        ResultResponse<T> GetMaxIdServiceResponse<T>();
        ResultResponse<T> GetEntityByIdServiceResponse<T>(long srNo);
        ResultResponse<T> SaveListServiceResponse<T>(List<T> entityList);
        ResultResponse<T> SaveServiceResponse<T>(T entity);
        ResultResponse<T> EditServiceResponse<T>(T entity);
        ResultResponse<T> DeleteServiceResponse<T>(long srNo, string deletedBy, string deleteReason);
        ResultResponse<T> CustomServiceResponse<T>(string methodName, params object[] parameters);
    }

    public class WinServices : IServices
    {
        private readonly Type _dataServiceType;
        private readonly object _dataServiceInstance;

        public WinServices(string entityName)
        {
            var serviceAssembly = typeof(UserDataService).Assembly;
            var className = serviceAssembly.GetName().Name + "." + "Services" + "." + entityName + "DataService";
            _dataServiceType = serviceAssembly.GetType(className);
            _dataServiceInstance = serviceAssembly.CreateInstance(className);
        }

        public ResultResponse<T> GetServiceResponse<T>(ReportRequest request)
        {
            var method = _dataServiceType.GetMethod("Get");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { request });
        }

        public ResultResponse<T> GetReportPageDataServiceResponse<T>()
        {
            var method = _dataServiceType.GetMethod("GetReportPageData");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, null);
        }

        public ResultResponse<T> GetEntryPageDataServiceResponse<T>()
        {
            var method = _dataServiceType.GetMethod("GetEntryPageData");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, null);
        }

        public ResultResponse<T> GetMaxIdServiceResponse<T>()
        {
            var method = _dataServiceType.GetMethod("GetMaxId");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, null);
        }


        public ResultResponse<T> GetEntityByIdServiceResponse<T>(long srNo)
        {
            var method = _dataServiceType.GetMethod("GetEntityById");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { srNo });
        }

        public ResultResponse<T> SaveListServiceResponse<T>(List<T> entityList)
        {
            var method = _dataServiceType.GetMethod("SaveList");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { entityList });
        }

        public ResultResponse<T> SaveServiceResponse<T>(T entity)
        {
            var method = _dataServiceType.GetMethod("Save");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { entity });
        }

        public ResultResponse<T> EditServiceResponse<T>(T entity)
        {
            var method = _dataServiceType.GetMethod("Edit");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { entity });
        }

        public ResultResponse<T> DeleteServiceResponse<T>(long srNo, string deletedBy, string deleteReason)
        {
            var method = _dataServiceType.GetMethod("Delete");

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, new object[] { srNo, deletedBy, deleteReason });
        }

        public ResultResponse<T> CustomServiceResponse<T>(string methodName, params object[] parameters)
        {
            var method = _dataServiceType.GetMethod(methodName);

            return (ResultResponse<T>)method.Invoke(_dataServiceInstance, parameters);
        }
    }
}
