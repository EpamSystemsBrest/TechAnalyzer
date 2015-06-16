using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace ServiceLibrary
{
    public class InformationController : ApiController
    {
        public JsonResult<string> Get()
        {
            var log = new LogInformation()
            {
                CurrentUrl = Service.CurrentUrl,
                CountDownloadUrl = Service.CountDownloadUrl,
                StartTime = Service.StartTime.ToString(),
                Speed = string.Format("{0:F3} {1}",Service.Speed,"КB/s")
            };
            return Json(JsonConvert.SerializeObject(log));
        }
    }

}
