using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuracoes
{
    public class ImovelConfiguracao : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(i => i.Id)
                .ValueGeneratedOnAdd();

            builder.Property(i => i.TipoNegocio)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(i => i.Descricao)
                .HasColumnType("nvarchar(250)");

            builder.Property(i => i.Valor)
                .IsRequired()
                .HasColumnType("numeric(18,3)");

            builder.Property(i => i.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            builder.HasOne(c => c.Cliente).WithOne();
        }
    }
}
