using DesafioTecnicoBanking.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioTecnicoBanking
{
    public partial class FormNovaConta : Form
    {
        private Form1 formPrincipal;
        public FormNovaConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        public Conta TipoDeConta()
        {
            int indice = comboTipoDeConta.SelectedIndex;
            if (indice == 0)
            {
                return new ContaCorrente();
            }
            else
            {
                return new ContaPoupanca();
            }
        }

        private void FormNovaConta_Load(object sender, EventArgs e)
        {
            ContaCorrente novaConta = new ContaCorrente();
            textoConta.Text = Convert.ToString(novaConta.ProximoNumeroConta());
            textoAgencia.Text = Convert.ToString(novaConta.Agencia);
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCriar_Click(object sender, EventArgs e)
        {
            //int criarAgencia = Convert.ToInt32(textoAgencia.Text);
            string criarTitular = textoTitular.Text;

            var novaConta = TipoDeConta();
            novaConta.Titular = new Pessoa(criarTitular);
            this.formPrincipal.AdicionarConta(novaConta);
            MessageBox.Show($"Nova conta criada para {novaConta.Titular.Nome} : Agência {novaConta.Agencia} - Número da Conta {novaConta.NumeroConta}");
            textoTitular.Text = "";
            textoConta.Text = Convert.ToString(novaConta.ProximoNumeroConta());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
