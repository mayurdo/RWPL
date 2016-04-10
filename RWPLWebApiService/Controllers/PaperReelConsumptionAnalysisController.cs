using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RWPLEntityModel;
using RWPLEntityModel.SearchRequest;
using RWPLLinqDataService;
using RWPLLinqDataService.Services;

namespace RWPLWebApiService.Controllers
{
    public class PaperReelConsumptionAnalysisController : ApiController
    {
        // GET api/paperreelconsumptionanalysis
        [HttpPost]
        public ResultResponse<PaperReelConsumptionAnalysi> Get(PaperReelConsumptionAnalysiSearchRequest request)
        {
            var paper = new PaperReelConsumptionAnalysiDataService();
            return paper.Get(request);
        }

        // GET api/paperreelconsumptionanalysis/5
        public ResultResponse<PaperReelConsumption> Get(int id)
        {
            //var paper = new PaperReelConsumptionAnalysiDataService();
           // return paper.GetEntityById(id);
            return null;
        }

        // POST api/paperreelconsumptionanalysis
        public void Post([FromBody]string value)
        {
        }

        // PUT api/paperreelconsumptionanalysis/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/paperreelconsumptionanalysis/5
        public void Delete(int id)
        {
        }
    }
}
