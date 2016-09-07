using System;
using System.Collections.Generic;
using HDomain.Projecoes;
using HDomain.Repositories;
using System.Linq;
using HInfrastructure.Persistence.DataContext;
using System.Data.Entity;

namespace HInfrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly StoreDataContext _storeDataContext;

        public TarefaRepository(StoreDataContext storeDataContext)
        {
            this._storeDataContext = storeDataContext;
        }

        public List<GridTarefaDoAluno> ListarTarefaDeAlunoPorAluno(string idAluno)
        {
            var lista = this._storeDataContext.TarefaAlunos.Where(x => x.AlunoID == idAluno)
                .Include(x => x.Aluno).Include(x => x.Tarefa).Include(x => x.Tarefa.TurmaMateria)
                .Include(x => x.Tarefa.TurmaMateria.Materia).Include(x => x.Tarefa.TurmaMateria.Professor)
                .Select(tarefa => new GridTarefaDoAluno()
                {
                    ID = tarefa.ID,
                    IdDaTarefa = tarefa.TarefaID,
                    IdDoAluno = tarefa.AlunoID,
                    Materia = tarefa.Tarefa.TurmaMateria.Materia.Nome,
                    Professor = tarefa.Tarefa.TurmaMateria.Professor.Nome,
                    DataInicial = tarefa.Tarefa.DataInicio,
                    DataFinal = tarefa.Tarefa.DataFinal,
                    TarefaTitulo = tarefa.Tarefa.Titulo,
                    TarefaDescricacao = tarefa.Tarefa.Descricao,
                    NotaDaTarefa = tarefa.Tarefa.Nota,
                    NotaDoAluno = tarefa.Nota,
                    NaoConformidade = tarefa.NaoConformidade,
                    NaoConformidadeDescricao = tarefa.DescricaoNaoConformidade,
                    VerificadoPeloPai = tarefa.VerificadoPeloPai
                }).ToList();
            return lista;
        }

        public List<GridTarefaDoAluno> ListarTarefaDeAlunoPorTerefa(int idTarefa)
        {

            var lista = this._storeDataContext.TarefaAlunos.Where(x => x.TarefaID == idTarefa)
                .Include(x => x.Aluno)
                .Select(tarefa => new GridTarefaDoAluno()
                {
                    ID = tarefa.ID,
                    IdDaTarefa = tarefa.TarefaID,
                    IdDoAluno = tarefa.AlunoID,
                    NomeDoAluno = tarefa.Aluno.Nome,
                    NotaDoAluno = tarefa.Nota,
                    NaoConformidade = tarefa.NaoConformidade,
                    NaoConformidadeDescricao = tarefa.DescricaoNaoConformidade,
                    VerificadoPeloPai = tarefa.VerificadoPeloPai
                }).ToList();
            return lista;
        }

        public List<GridTarefa> ListarTarefasPorSala(int idSalaMatera)
        {
            var lista = this._storeDataContext.Tarefas.Where(x => x.TurmaMateriaID == idSalaMatera)
                .Select(x => new GridTarefa()
                {
                    ID = x.ID,
                    IDMateriaTurma = x.TurmaMateriaID,
                    Titulo = x.Titulo,
                    Descricao = x.Descricao,
                    DataInicio = x.DataInicio,
                    DataFinal = x.DataFinal,
                    Nota = x.Nota
                }).ToList();

            return lista;
        }
    }
}
