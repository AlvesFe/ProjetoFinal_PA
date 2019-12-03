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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboEstado.SelectedIndex = 0;
        }

        Cliente objCliente;
        

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
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtConfSenha.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtRg.Clear();
            txtSenha.Clear();
            comboEstado.SelectedIndex = 0;
            radioAttackHelicopter.Checked = false;
            radioFem.Checked = false;
            radioMasc.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objCliente = new Cliente(txtNome.Text,txtEmail.Text,txtEndereco.Text,txtBairro.Text,txtCidade.Text,
                    comboEstado.SelectedItem.ToString(),txtRg.Text,txtCpf.Text,txtNumero.Text,txtCep.Text);
                if (string.IsNullOrWhiteSpace(objCliente.nome))
                {
                    throw new Exception("Nome está vazio!");
                }
                if (string.IsNullOrWhiteSpace(objCliente.rg))
                {
                    throw new Exception("RG está vazio!");
                }
                if (objCliente.rg.Length != 9)
                {
                    throw new Exception("RG deve conter 9 digitos!");
                }
                if (string.IsNullOrWhiteSpace(objCliente.cpf))
                {
                    throw new Exception("CPF está vazio!");
                }
                if (objCliente.cpf.Length != 11)
                {
                    throw new Exception("CPF deve conter 11 digitos!");
                }
                if (string.IsNullOrWhiteSpace(objCliente.email))
                {
                    throw new Exception("Email está vazio");
                }
                if (string.IsNullOrWhiteSpace(objCliente.endereco))
                {
                    throw new Exception("Endereco está vazio");
                }
                if (string.IsNullOrWhiteSpace(objCliente.bairro))
                {
                    throw new Exception("Bairro está vazio");
                }
                if (string.IsNullOrWhiteSpace(objCliente.cidade))
                {
                    throw new Exception("Cidade está vazio");
                }
                if (string.IsNullOrWhiteSpace(objCliente.numero))
                {
                    throw new Exception("Número está vazio");
                }
                try
                {
                    Convert.ToInt64(objCliente.numero);
                }
                catch
                {
                    throw new Exception("Campo número não é numerico");
                }
                if (objCliente.estado == "Selecione")
                {
                    throw new Exception("Nenhum estado selecionado");
                }
                if (string.IsNullOrWhiteSpace(objCliente.cep))
                {
                    throw new Exception("CEP está vazio");
                }
                if (objCliente.cep.Length != 8)
                {
                    throw new Exception("CEP deve ter 8 digitos!");
                }
                if (radioMasc.Checked == false && radioFem.Checked && radioAttackHelicopter.Checked)
                {
                    throw new Exception("Sexo não selecionado");
                }
                if (radioMasc.Checked == true)
                {
                    objCliente.sexo = "Masculino";
                }
                else if (radioFem.Checked == true)
                {
                    objCliente.sexo = "Feminino";
                }
                else
                {
                    objCliente.sexo = "Outro";
                }
                if (string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    throw new Exception("Senha está vazia");
                }
                if (string.IsNullOrWhiteSpace(txtConfSenha.Text))
                {
                    throw new Exception("Confirmar senha está vazia");
                }
                if (txtSenha.Text == txtConfSenha.Text)
                {
                    objCliente.senha = txtSenha.Text;
                }
                else
                {
                    throw new Exception("Senhas não coincidem");
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
