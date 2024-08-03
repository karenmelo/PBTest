using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PB.CadastroCliente.API.Models;
using PB.Core.DomainObject;

namespace PB.CadastroCliente.API.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);


            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(200");


            builder.OwnsOne(c => c.Cpf, tf => { 
                tf.Property(c => c.Numero)
                  .IsRequired()
                  .HasMaxLength(Cpf.CpfMaxLength)
                  .HasColumnName("Cpf")
                  .HasColumnType($"varchar({Cpf.CpfMaxLength})");
            });


            builder.OwnsOne(c => c.Email, tf => {
                tf.Property(c => c.Endereco)
                  .IsRequired()
                  .HasColumnName("Dmail")
                  .HasColumnType($"varchar({Email.EnderecoMaxLength})");
            });



            builder.Property(c => c.DataNascimento)
                   .IsRequired()
                   .HasColumnType("date");

            builder.Property(c => c.DataCadastro)
                   .IsRequired()
                   .HasColumnType("date");

            builder.Property(c => c.Celular)
                   .IsRequired()
                   .HasColumnType("int");

            //1:1 => cliente : endereco
            builder.HasOne(c => c.Endereco)
                   .WithOne(c => c.Cliente);


            builder.ToTable("Clientes");

        }
    }
}
