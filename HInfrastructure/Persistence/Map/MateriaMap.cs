using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class MateriaMap : EntityTypeConfiguration<Materia>
    {
        public MateriaMap()
        {
            ToTable("tbMateria");
            HasKey(x => x.ID);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50);
            Property(x => x.CargaHoraria).HasColumnName("cargaHoraria");

        }
    }
}
