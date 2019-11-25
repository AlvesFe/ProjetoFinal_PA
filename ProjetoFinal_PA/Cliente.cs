using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_PA
{
    public class Cliente
    {
        public string nome, email, endereco, bairro, cidade, estado, sexo, senha, rg, cpf, numero, cep;

        public Cliente(string nome, string email, string endereco, string bairro, string cidade, string estado, string rg, string cpf, string numero, string cep)
        {
            this.nome = nome;
            this.email = email;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.rg = rg;
            this.cpf = cpf;
            this.numero = numero;
            this.cep = cep;
        }
    }
}
