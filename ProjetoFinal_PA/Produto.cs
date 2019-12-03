using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_PA
{
    public class Produto
    {
        public string nome, descricao, tipo, codBarras, preco, estoque, unidade;

        public Produto(string nome, string descricao, string tipo, string codBarras, string preco, string estoque, string unidade)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.tipo = tipo;
            this.codBarras = codBarras;
            this.preco = preco;
            this.estoque = estoque;
            this.unidade = unidade;
        }
    }
}
