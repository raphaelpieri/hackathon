namespace HDomain.Entities
{
    public class TarefaAluno
    {
        public TarefaAluno()
        {

        }
        public int ID { get; set; }
        public string AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int TarefaID { get; set; }
        public Tarefa Tarefa { get; set; }
        public string Nota { get; set; }
        public bool NaoConformidade { get; set; }
        public string DescricaoNaoConformidade { get; set; }
        public bool VerificadoPeloPai { get; set; }

    }
}
