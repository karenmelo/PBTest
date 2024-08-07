﻿using PB.Core.DomainObject;

namespace PB.CadastroCliente.API.Models
{
    public class Cliente : Entity, IAggregateRoot
    {
        protected Cliente()
        {

        }

        public Cliente(Guid id, string nome, DateTime dataNascimento, Cpf cpf, Email email, int celular, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Email = email;
            Celular = celular;
            DataCadastro = DateTime.Now;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Cpf Cpf { get; private set; }
        public Email Email { get; private set; }
        public int Celular { get; private set; }
        public DateTime DataCadastro { get; private set; }


        public Endereco Endereco { get; set; }



        public void TrocarEmail(string email)
        {
            Email = new Email(email);
        }

        public void AtribuirEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
