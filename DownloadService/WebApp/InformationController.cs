using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace DownloadService
{
    public class InformationController : ApiController
    {
        private readonly Statistics _statistics;

        public InformationController(Statistics statistic)
        {
            _statistics = statistic;
        }

        public JsonResult<string> Get()
        {
            return Json(JsonConvert.SerializeObject(_statistics.GetUsageDetails()));
        }
    }
}
