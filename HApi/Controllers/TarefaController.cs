using HDomain.Repositories;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HApi.Controllers
{
    public class TarefaController : BaseController
    {
        private readonly ITarefaRepository _tarefaRepository;
        public TarefaController(ITarefaRepository tarefaRepository)
        {
            this._tarefaRepository = tarefaRepository;
        }

        [HttpGet]
        //[Authorize]
        [Route("api/tarefas/{id}")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var tarefas = this._tarefaRepository.ListarTarefasPorSala(id);
            return CreateResponse(HttpStatusCode.Created, tarefas);
        }

        [HttpGet]
        [Route("api/tarefaalunotarefa/{id}")]
        public Task<HttpResponseMessage> GetTarefa(int id)
        {
            var tarefas = this._tarefaRepository.ListarTarefaDeAlunoPorTerefa(id);
            return CreateResponse(HttpStatusCode.Created, tarefas);
        }

        [HttpGet]
        [Route("api/tarefaaluno/{id}")]
        public Task<HttpResponseMessage> GetTarefaAluno(string id)
        {
            var tarefas = this._tarefaRepository.ListarTarefaDeAlunoPorAluno(id);
            return CreateResponse(HttpStatusCode.Created, tarefas);
        }
    }
}