using HDomain.Repositories;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HApi.Controllers
{
    public class AlunoController : BaseController
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository)
        {
            this._alunoRepository = alunoRepository;
        }

        [HttpGet]
        //[Authorize]
        [Route("api/alunos/{id}")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var alunos = this._alunoRepository.ListaDeAlunoPorPai(id);
            return CreateResponse(HttpStatusCode.Created, alunos);
        }
    }
}