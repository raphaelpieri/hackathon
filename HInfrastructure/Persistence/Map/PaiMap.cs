using HDomain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace HInfrastructure.Persistence.Map
{
    public class PaiMap : EntityTypeConfiguration<Pai>
    {
        public PaiMap()
        {
            ToTable("tbPai");
            HasKey(x => x.Id);

            Property(x => x.Email).HasColumnName("email").HasMaxLength(50);
            Property(x => x.Cpf).HasColumnName("cpf").IsRequired().HasMaxLength(20);
            Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            Property(x => x.Senha).HasColumnName("senha").HasMaxLength(50).IsRequired();
            Property(x => x.Tipo).HasColumnName("tipo").IsRequired();
        }
    }
}
