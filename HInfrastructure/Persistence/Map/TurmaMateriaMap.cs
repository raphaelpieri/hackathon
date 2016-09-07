using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class TurmaMateriaMap: EntityTypeConfiguration<TurmaMateria>
    {
        public TurmaMateriaMap()
        {
            ToTable("tbTurmaMateria");
            HasKey(x => x.Id);

            HasRequired(x => x.Professor);
            HasRequired(x => x.Materia);
            HasRequired(x => x.Turma);

        }
    }
}
