using PB.Core.DomainObject;

namespace PB.CadastroCliente.API.Models;

public class Endereco : Entity
{
    //public Endereco()
    //{
        
    //}
    public Endereco(string logradouro, int numero, string complemento, string bairro, string cidade, string cep, string estado, string pais, bool principal)
    {
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
        Estado = estado;
        Pais = pais;
        Principal = principal;
    }

    public string Logradouro { get; private set; }
    public int Numero { get; private set; }
    public string Complemento { get; private set; }
    public string Bairro { get; private set; }
    public string Cidade { get; private set; }
    public string Cep { get; set; }
    public string Estado { get; private set; }
    public string Pais { get; private set; }
    public bool Principal { get; private set; }


    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }
}
