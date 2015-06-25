using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace DownloadService
{
    public class InformationController : ApiController
    {
        private readonly Statistics statistics;

        public InformationController(Statistics statistic)
        {
            statistics = statistic;
        }

        public JsonResult<string> Get()
        {
            return Json(JsonConvert.SerializeObject(statistics.GetUsageDetails()));
        }
    }
}
