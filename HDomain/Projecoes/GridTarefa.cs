using System;

namespace HDomain.Projecoes
{
    public class GridTarefa
    {
        public int ID { get; set; }
        public int IDMateriaTurma { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public string Nota { get; set; }

        public string DataInicioString
        {
            get { return this.DataInicio.ToShortDateString(); }
            private set { }
        }

        public string DataFinalString
        {
            get { return this.DataFinal.ToShortDateString(); }
            private set { }
        }

    }
}
