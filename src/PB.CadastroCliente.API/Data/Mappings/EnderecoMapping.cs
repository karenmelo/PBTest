﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PB.CadastroCliente.API.Models;
using System.Threading.Tasks.Dataflow;

namespace PB.CadastroCliente.API.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(e => e.Numero)
                    .IsRequired()
                   .HasColumnType("varchar(50)");
            builder.Property(e => e.Complemento)
                   .HasColumnType("varchar(250)");

            builder.Property(e => e.Bairro)
                    .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(e => e.Cidade)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(e => e.Cep)
                   .IsRequired()
                   .HasColumnType("varchar(20)");

            builder.Property(e => e.Estado)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(e => e.Pais)
                   .IsRequired()
                   .HasColumnType("varchar(50)");


            builder.HasOne(e => e.Cliente)
                   .WithOne(e => e.Endereco)
                   .HasForeignKey<Cliente>(p => new { p.Id}); ;


            builder.ToTable("Enderecos");


        }
    }
}
