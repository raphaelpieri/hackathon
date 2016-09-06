using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HApi.Controllers
{
    public class TesteController : BaseController
    {
        [HttpGet]
        [Route("api/teste")]
        public Task<HttpResponseMessage> Get()
        {
            return CreateResponse(HttpStatusCode.Created, "Ola esse é um teste");
        }
    }
}