using System;

namespace HDomain.Entities
{
    public class Tarefa
    {
        public Tarefa()
        {

        }
        public int ID { get; set; }
        public int TurmaMateriaID { get; set; }
        public TurmaMateria TurmaMateria { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public string Nota { get; set; }
    }
}
