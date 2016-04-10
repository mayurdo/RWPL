using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWPLEntityModel;

namespace RWPLLinqDataService.Services
{
    public class ApplicationDataRequestDataService
    {
        public ResultResponse<ApplicationDataRequest> Get()
        {
            var response = new ResultResponse<ApplicationDataRequest>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryableItems = rwplDb.GetTable<ItemMaster>()
                        .Where(x => !x.IsDeleted)
                        .OrderBy(x => x.ItemName);

                    var queryableCustomers = rwplDb.GetTable<CustomerMaster>()
                        .Where(x => !x.IsDeleted)
                        .OrderBy(x => x.CustomerName);

                    var queryableReelNo = rwplDb.GetTable<InwardMaster>()
                        .Where(x => !x.IsDeleted)
                        .OrderBy(x => x.ReelNo);

                    response.Object = new ApplicationDataRequest()
                    {
                        Items = queryableItems.ToList(),
                        Customers = queryableCustomers.ToList(),
                        Stocks = queryableReelNo.ToList()
                    };

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
