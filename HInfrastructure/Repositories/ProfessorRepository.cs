using System;
using HDomain.Entities;
using HDomain.Repositories;
using HInfrastructure.Persistence.DataContext;
using System.Linq;
using HDomain.Specs;

namespace HInfrastructure.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly StoreDataContext _storeDataContext;

        public ProfessorRepository(StoreDataContext storeDataContext)
        {
            this._storeDataContext = storeDataContext;
        }
        public Pessoa AutenticarProfessor(string cpf, string senha)
        {
            return this._storeDataContext.Professores.Where(ProfessorSpecs.AutenticarUsuarios(cpf, senha)).FirstOrDefault();
        }
    }
}
