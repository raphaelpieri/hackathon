using System.Collections.Generic;

namespace HDomain.Entities
{
    public class Aluno
    {
        private IList<AlunoMateriaTurma> _alunoMateriaTurma;
        public string ID { get; private set; }
        public string Nome { get; private set; }
        public int PaiID { get; set; }
        public Pai Pai { get; set; }

        public ICollection<AlunoMateriaTurma> AlunoMateriaTurma
        {
            get { return _alunoMateriaTurma; }
            private set { _alunoMateriaTurma = new List<AlunoMateriaTurma>(value); }
        }
    }
}
