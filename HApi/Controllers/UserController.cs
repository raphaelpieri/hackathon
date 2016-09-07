using HDomain.Commands;
using HDomain.Enums;
using HDomain.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace HApi.Controllers
{
    public class UserController : BaseController
    {
        private readonly IServiceProfessor _serviceProfessor;
        private readonly IServicoPai _servicoPai;

        public UserController(IServiceProfessor serviceProfessor, IServicoPai servicoPai)
        {
            this._serviceProfessor = serviceProfessor;
            this._servicoPai = servicoPai;
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var usuario = new UsuarioCommand(
                cpf: (string)body.cpf,
                senha:(string)body.senha
                );

            if(string.IsNullOrEmpty(usuario.Cpf) || string.IsNullOrEmpty(usuario.Senha))
            {
                return CreateResponse(HttpStatusCode.BadRequest, null);
            }

            var achouProfessor = this._serviceProfessor.Autenticar(usuario);
            var achouPai = this._servicoPai.Autenticar(usuario);

            if (achouPai != null && achouProfessor != null)
            {
                achouProfessor.AlterarTipo(TipoPessoa.Ambos);
                return CreateResponse(HttpStatusCode.OK, achouProfessor);
            }else if (achouProfessor != null) {
                return CreateResponse(HttpStatusCode.OK, achouProfessor);
            }else
            {
                return CreateResponse(HttpStatusCode.OK, achouPai);
            }
            
            

        }
    }
}