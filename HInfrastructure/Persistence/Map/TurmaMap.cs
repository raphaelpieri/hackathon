using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            ToTable("tbTurma");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50);

            HasMany(x => x.TurmaMateria).WithRequired(x => x.Turma);
        }
    }
}
