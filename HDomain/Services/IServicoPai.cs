using HDomain.Commands;
using HDomain.Entities;

namespace HDomain.Services
{
    public interface IServicoPai
    {
        Pessoa Autenticar(UsuarioCommand pai);
    }
}
