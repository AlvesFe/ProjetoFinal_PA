using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_PA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboTipo.SelectedIndex = 0;
        }

        Produto objProduto;

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar?", "Voltar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 inicio = new Form1();
                inicio.ShowDialog();
                this.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodBarras.Clear();
            txtEstoque.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtUnidade.Clear();
            comboTipo.SelectedIndex = 0;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objProduto = new Produto(txtNome.Text, txaDescricao.Text, comboTipo.SelectedItem.ToString(), txtCodBarras.Text, txtPreco.Text, txtEstoque.Text, txtUnidade.Text);
                if (string.IsNullOrWhiteSpace(objProduto.codBarras))
                {
                    throw new Exception("Código de Barras está vazio!");
                }
                try
                {
                    Convert.ToInt64(objProduto.codBarras);
                }
                catch
                {
                    throw new Exception("Código de Barras não é numérico");
                }
                if (string.IsNullOrWhiteSpace(objProduto.nome))
                {
                    throw new Exception("Nome está vazio!");
                }
                if (string.IsNullOrWhiteSpace(objProduto.descricao))
                {
                    throw new Exception("Descrição está vazia!");
                }
                if (string.IsNullOrWhiteSpace(objProduto.preco))
                {
                    throw new Exception("Preço está vazio!");
                }
                try
                {
                    Convert.ToDouble(objProduto.preco);
                }
                catch
                {
                    throw new Exception("Preço não é numérico");
                }
                if (string.IsNullOrWhiteSpace(objProduto.estoque))
                {
                    throw new Exception("Estoque está vazio!");
                }
                try
                {
                    Convert.ToInt64(objProduto.estoque);
                }
                catch
                {
                    throw new Exception("Estoque não é numérico");
                }
                if (string.IsNullOrWhiteSpace(objProduto.unidade))
                {
                    throw new Exception("Unidade está vazia!");
                }
                try
                {
                    Convert.ToInt64(objProduto.unidade);
                }
                catch
                {
                    throw new Exception("Unidade não é numérico");
                }
                if (objProduto.tipo == "Selecione")
                {
                    throw new Exception("Tipo não selecionado");
                }
                if (MessageBox.Show("Cadastro concluido com êxito! \nVocê será redirecionado para a tela inicial", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Form1 inicio = new Form1();
                    this.Hide();
                    inicio.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
