using System;
using System.Linq;
using RWPLEntityModel;
using RWPLEntityModel.PageDataRequest;
using RWPLEntityModel.SearchRequest;

namespace RWPLLinqDataService.Services
{
    public class PaperReelConsumptionAnalysiDataService :
    IReportService<PaperReelConsumptionAnalysi, PaperReelConsumptionAnalysiSearchRequest, PaperReelConsumptionReportPageRequest>
    {
        public ResultResponse<PaperReelConsumptionAnalysi> Get(PaperReelConsumptionAnalysiSearchRequest request)
        {
            var response = new ResultResponse<PaperReelConsumptionAnalysi>();
            try
            {
                using (var rwplDb = new RWPLLinqDataContext())
                {
                    var queryable = rwplDb.GetTable<PaperReelConsumptionAnalysi>()
                        .Where(x => x.Machine.Contains(request.Machine)
                                    && (!request.IsSearchByDate ||
                                        (x.Date >= request.FromDate.Date && x.Date <= request.ToDate.Date))
                        )
                        .OrderBy(x => x.Date);

                    if (request.ShowAllData)
                    {
                        response.PageData = queryable.ToList();
                        response.IsSuccess = true;
                        return response;
                    }

                    var skipRecord = ((request.PageNo > 0) ? (request.PageNo - 1) * request.PageSize : 0);
                    response.PageData = queryable.Skip(skipRecord).Take(request.PageSize).ToList();
                    response.TotalItem = queryable.Count();

                    if (response.TotalItem > 0)
                    {
                        var totalProduction = queryable.Select(x => x.Production_Kg).Sum();
                        var avgProduction = Math.Round((queryable.Select(x => x.AvgProduction_KgPerHr).Sum() / response.TotalItem).Value);
                        var totalGumUse = queryable.Select(x => x.GumUse_kg).Sum();
                        var avgGumUse = Math.Round((queryable.Select(x => x.AvgGumUse_KgPerTon).Sum() / response.TotalItem).Value);
                        var totalWastage = queryable.Select(x => x.Wastage_kg).Sum();
                        var avgWastage = Math.Round((queryable.Select(x => x.AvgWastage_KgPerTon).Sum() / response.TotalItem).Value);
                        var totalReel = queryable.Select(x => x.NoOfReel).Distinct().Count();

                        response.ReportSummary = string.Format("Total Production : {0}, Avg Production : {1}, Total Gum use : {2}, " +
                                                               "Avg Gum use: {3}, Total Wastage:{4}, Avg Wastage:{5}, Total Reel:{6}",
                                                                 totalProduction, avgProduction, totalGumUse, avgGumUse, totalWastage, avgWastage, totalReel);
                    }

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

        public ResultResponse<PaperReelConsumptionReportPageRequest> GetReportPageData()
        {
            throw new NotImplementedException();
        }
    }
}