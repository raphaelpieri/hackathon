namespace HDomain.Entities
{
    public class AlunoMateriaTurma
    {
        public AlunoMateriaTurma()
        {

        }
        public int ID { get; set; }
        public int TurmaMateriaId { get; set; }
        public TurmaMateria TurmaMateria { get; set; }
        public string AlunoID { get; set; }
        public Aluno Aluno { get; set; }
    }
}
