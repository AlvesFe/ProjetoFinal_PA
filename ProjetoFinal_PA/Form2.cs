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
        }

        Cliente objCliente;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.ShowDialog();
            this.Close();
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
            comboEstado.SelectedIndex = -1;
            radioAttackHelicopter.Checked = false;
            radioFem.Checked = false;
            radioMasc.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objCliente = new Cliente(txtNome.Text,txtEmail.Text,txtEndereco.Text,txtBairro.Text,txtCidade.Text,comboEstado.SelectedItem.ToString(),txtRg.Text,txtCpf.Text,txtNumero.Text,txtCep.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
