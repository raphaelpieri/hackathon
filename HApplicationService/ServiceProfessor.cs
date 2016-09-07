using System;
using HDomain.Commands;
using HDomain.Entities;
using HDomain.Services;
using HDomain.Repositories;

namespace HApplicationService
{
    public class ServiceProfessor : IServiceProfessor
    {
        private readonly IProfessorRepository _professorRepository;
        public ServiceProfessor(IProfessorRepository professorRepository)
        {
            this._professorRepository = professorRepository;
        }
        public Pessoa Autenticar(UsuarioCommand professor)
        {
            return _professorRepository.AutenticarProfessor(professor.Cpf, professor.Senha);
        }
    }
}
