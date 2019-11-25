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
        }

        Produto objProduto = new Produto();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.ShowDialog();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodBarras.Clear();
            txtEstoque.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtUnidade.Clear();
            comboTipo.SelectedIndex = -1;
        }
    }
}
