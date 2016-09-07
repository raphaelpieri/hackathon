using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class TarefaAlunoMap : EntityTypeConfiguration<TarefaAluno>
    {
        public TarefaAlunoMap()
        {
            ToTable("tbTarefaAluno");
            HasKey(x => x.ID);
            Property(x => x.Nota).HasColumnName("nota");
            Property(x => x.NaoConformidade).HasColumnName("naoConformidade");
            Property(x => x.DescricaoNaoConformidade).HasColumnName("descricaoNConf");
            Property(x => x.VerificadoPeloPai).HasColumnName("verificadoPeloPai");
            HasRequired(x => x.Aluno);
            HasRequired(x => x.Tarefa);
        }
    }
}
