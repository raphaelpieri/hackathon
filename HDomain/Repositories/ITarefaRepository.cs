using HDomain.Projecoes;
using System.Collections.Generic;

namespace HDomain.Repositories
{
    public interface ITarefaRepository
    {
        List<GridTarefa> ListarTarefasPorSala(int idSalaMatera);
        List<GridTarefaDoAluno> ListarTarefaDeAlunoPorTerefa(int idTarefa);
        List<GridTarefaDoAluno> ListarTarefaDeAlunoPorAluno(string idAluno);
    }
}
