using System;

namespace HDomain.Projecoes
{
    public class GridTarefaDoAluno
    {
        public int ID { get; set; }
        public int IdDaTarefa { get; set; }
        public string IdDoAluno { get; set; }
        public string NomeDoAluno { get; set; }
        public string Materia { get; set; }
        public string TarefaTitulo { get; set; }
        public string TarefaDescricacao { get; set; }
        public string Professor { get; set; }
        public string NotaDaTarefa { get; set; }
        public string NotaDoAluno { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public bool NaoConformidade { get; set; }
        public string NaoConformidadeDescricao { get; set; }
        public bool VerificadoPeloPai { get; set; }
        public string DataInicioString
        {
            get { return this.DataInicial != null ? this.DataInicial.ToShortDateString() : string.Empty; }
            private set { }
        }
        public string DataFinalString
        {
            get { return this.DataFinal != null ? this.DataFinal.ToShortDateString() : string.Empty; }
            private set { }
        }
    }
}
