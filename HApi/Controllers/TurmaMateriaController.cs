using HDomain.Repositories;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HApi.Controllers
{
    public class TurmaMateriaController : BaseController
    {
        private readonly IRepositoryTurmaMateria _repositoryTurmaMateria;

        public TurmaMateriaController(IRepositoryTurmaMateria repositoryTurmaMateria)
        {
            this._repositoryTurmaMateria = repositoryTurmaMateria;
        }

        [HttpGet]
        //[Authorize]
        [Route("api/materias/{id}")]
        public Task<HttpResponseMessage> Get(int id)
        {
            var materias = this._repositoryTurmaMateria.ListaMateriaPorProfessor(id);
            return CreateResponse(HttpStatusCode.Created, materias);
        }

        [HttpGet]
        //[Authorize]
        [Route("api/turmas/{idProfessor}/{idMateria}")]
        public Task<HttpResponseMessage> Get(int idProfessor, int idMateria)
        {
            var turmas = this._repositoryTurmaMateria.ListaSalaPorMateria(idProfessor, idMateria);

            return CreateResponse(HttpStatusCode.Created, turmas);
        }
    }
}