using System.Collections.Generic;

namespace HDomain.Entities
{
    public class Turma
    {
        public Turma()
        {

        }

        private IList<TurmaMateria> _turmaMateria;
        
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<TurmaMateria> TurmaMateria
        {
            get { return _turmaMateria; }
            private set { _turmaMateria = new List<TurmaMateria>(value); }
        }


    }
}
