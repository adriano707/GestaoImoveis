using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuracoes
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(i => i.IsAtivo)
                .HasColumnType("int");

            builder.Property(i => i.Email)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            builder.Property(i => i.Cpf)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
        }
    }    
}
