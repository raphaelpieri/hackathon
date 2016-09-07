using System;
using HDomain.Entities;
using HDomain.Repositories;
using HInfrastructure.Persistence.DataContext;
using System.Linq;
using HDomain.Specs;

namespace HInfrastructure.Repositories
{
    public class PaiRepository : IPaiRepository
    {
        private readonly StoreDataContext _storeDataContext;

        public PaiRepository(StoreDataContext storeDataContext)
        {
            this._storeDataContext = storeDataContext; 
        } 
        public Pessoa AutenticarPai(string cpf, string senha)
        {
            return _storeDataContext.Pais.Where(PaiSpecs.AutenticarPai(cpf, senha)).FirstOrDefault();
        }
    }
}
