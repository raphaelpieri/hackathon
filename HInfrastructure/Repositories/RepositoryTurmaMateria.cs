using System;
using System.Collections.Generic;
using HDomain.Entities;
using HDomain.Repositories;
using HInfrastructure.Persistence.DataContext;
using System.Data.Entity;
using System.Linq;
using HDomain.Projecoes;

namespace HInfrastructure.Repositories
{
    public class RepositoryTurmaMateria : IRepositoryTurmaMateria
    {
        private readonly StoreDataContext _storeDataContext;
        public RepositoryTurmaMateria(StoreDataContext storeDataContext)
        {
            this._storeDataContext = storeDataContext;
        }
        public IList<GridDeMaterias> ListaMateriaPorProfessor(int idDoProfessor)
        {
            var lista = (from f in this._storeDataContext.Turmas
                         from fi in f.TurmaMateria
                         join m in _storeDataContext.Materias on fi.MateriaId equals m.ID
                         where fi.ProfessorId == idDoProfessor
                         group new { m.ID, m.Nome, fi.ProfessorId } by m into mgroup
                         select new GridDeMaterias()
                         {
                             Id = mgroup.Key.ID,
                             Nome = mgroup.Key.Nome                           
                         }
                         ).ToList();

            return lista;
        }

        public IList<GridDeTurmas> ListaSalaPorMateria(int idDoProfessor, int idDaMateria)
        {
            var lista = (from f in this._storeDataContext.Turmas
                         from fi in f.TurmaMateria
                         join m in _storeDataContext.Materias on fi.MateriaId equals m.ID
                         where fi.ProfessorId == idDoProfessor && m.ID == idDaMateria
                         select new GridDeTurmas()
                         {
                             ID = f.Id,
                             IdDaTurmaMateria = fi.Id,
                             Nome = f.Nome
                         }                         
                         ).ToList();

            return lista;
        }
    }
}
