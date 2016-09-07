using HDomain.Entities;
using HDomain.Projecoes;
using System.Collections.Generic;

namespace HDomain.Repositories
{
    public interface IAlunoRepository
    {
        List<Aluno> ListaDeAlunoPorPai(int codigoDoPai);
        List<GridTarefa> ListaDeMateriaPorAluno(int codigoDoAluno);
    }
}
