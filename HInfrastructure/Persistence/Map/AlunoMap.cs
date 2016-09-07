using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("tbAluno");
            HasKey(x => x.ID);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50);

            HasRequired(x => x.Pai);

            HasMany(x => x.AlunoMateriaTurma).WithRequired(x => x.Aluno);

        }
    }
}
