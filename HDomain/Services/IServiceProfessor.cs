using HDomain.Commands;
using HDomain.Entities;

namespace HDomain.Services
{
    public interface IServiceProfessor
    {
        Pessoa Autenticar(UsuarioCommand professor);
    }
}
