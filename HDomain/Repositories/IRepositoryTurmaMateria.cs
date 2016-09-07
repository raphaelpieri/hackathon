using HDomain.Entities;
using HDomain.Projecoes;
using System.Collections.Generic;

namespace HDomain.Repositories
{
    public interface IRepositoryTurmaMateria
    {
        IList<GridDeMaterias> ListaMateriaPorProfessor(int idDoProfessor);
        IList<GridDeTurmas> ListaSalaPorMateria(int idDoProfessor, int idDaMateria);
    }
}
