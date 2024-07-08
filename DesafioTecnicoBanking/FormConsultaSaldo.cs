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
    public partial class FormConsultaSaldo : Form
    {
        List<ContaCorrente> contas;
        private Form1 formPrincipal;
        public FormConsultaSaldo(Form1 formPrincipal)
        {
            contas = new List<ContaCorrente>();
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetTitulares(List<ContaCorrente> titulares)
        {
            foreach (var titular in titulares)
            {
                comboTitular.Items.Add(titular);
                contas.Add(titular);
            }
        }

        private void FormConsultaSaldo_Load(object sender, EventArgs e)
        {

        }

        private void comboTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboTitular.SelectedIndex;
            ContaCorrente selecionada = contas[indice];
            selecionada.ConsultarSaldo();

            textoAgencia.Text = Convert.ToString(selecionada.Agencia);
            textoConta.Text = Convert.ToString(selecionada.NumeroConta);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}
