using System;
using System.Collections.Generic;
using HDomain.Entities;
using HDomain.Repositories;
using HInfrastructure.Persistence.DataContext;
using System.Linq;
using HDomain.Projecoes;

namespace HInfrastructure.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly StoreDataContext _storeDataContext;

        public AlunoRepository(StoreDataContext storeDataContext)
        {
            this._storeDataContext = storeDataContext;
        }
        public List<Aluno> ListaDeAlunoPorPai(int codigoDoPai)
        {
            return this._storeDataContext.Alunos.Where(x => x.PaiID == codigoDoPai).ToList();
        }

        public List<GridTarefa> ListaDeMateriaPorAluno(int codigoDoAluno)
        {
            throw new NotImplementedException();
        }
    }
}
