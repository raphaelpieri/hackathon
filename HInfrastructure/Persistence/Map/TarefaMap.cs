using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            ToTable("tbTarefa");
            HasKey(x => x.ID);
            Property(x => x.Titulo).HasColumnName("titulo").HasMaxLength(50);
            Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(250);
            Property(x => x.DataInicio).HasColumnName("dataInicio").HasColumnType("datetime2");
            Property(x => x.DataFinal).HasColumnName("dataFinal").HasColumnType("datetime2");
            Property(x => x.Nota).HasColumnName("nota");
            HasRequired(x => x.TurmaMateria);
           
            
        }
    }
}
