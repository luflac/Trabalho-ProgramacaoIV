using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgramacaoIV.Venda.Api.Entidades;

namespace ProgramacaoIV.Venda.Api.Map
{
    public class VendedorMap : AbstractEntidadeMap<Vendedor>
    {
        public override void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            base.Configure(builder);

            builder.ToTable("VENDEDOR");

            builder.Property(x => x.Nome).HasColumnName("NM_VENDEDOR").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Email).HasColumnName("EMAIL").HasMaxLength(150).IsRequired();
        }
    }
}
