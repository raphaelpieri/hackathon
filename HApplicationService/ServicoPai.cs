using System;
using HDomain.Commands;
using HDomain.Entities;
using HDomain.Services;
using HDomain.Repositories;

namespace HApplicationService
{
    public class ServicoPai : IServicoPai
    {
        private readonly IPaiRepository _paiRepository;
        public ServicoPai(IPaiRepository paiRepository)
        {
            this._paiRepository = paiRepository;
        }
        public Pessoa Autenticar(UsuarioCommand pai)
        {
            return _paiRepository.AutenticarPai(pai.Cpf, pai.Senha);
        }
    }
}
