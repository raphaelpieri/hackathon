using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class AlunoMateriaTurmaMap : EntityTypeConfiguration<AlunoMateriaTurma>
    {
        public AlunoMateriaTurmaMap()
        {
            ToTable("tbAlunoMateiraTurma");
            HasKey(x => x.ID);
            HasRequired(x => x.TurmaMateria);
            HasRequired(x => x.Aluno);
        }
    }
}
