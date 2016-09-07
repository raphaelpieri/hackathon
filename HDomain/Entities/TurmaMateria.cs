namespace HDomain.Entities
{
    public class TurmaMateria
    {
        public TurmaMateria()
        {

        }
        public int Id { get; private set; }
        public int ProfessorId { get; private set; }
        public Professor Professor { get; private set; }
        public int MateriaId { get; private set; }
        public Materia Materia { get; private set; }
        public int TurmaId { get; private set; }
        public Turma Turma { get; private set; }
    }
}
