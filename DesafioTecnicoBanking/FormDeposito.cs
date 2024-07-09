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
    public partial class FormDeposito : Form
    {
        private List<Conta> contas;
        private Form1 formPrincipal;
        public FormDeposito(Form1 formPrincipal)
        {
            contas = new List<Conta>();
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        public void SetTitulares(List<Conta> titulares)
        {
            foreach (Conta titular in titulares)
            {
                comboDepositante.Items.Add(titular);
                comboDestino.Items.Add(titular);
                contas.Add(titular);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indiceDepositante = comboDepositante.SelectedIndex;
            int indiceDestino = comboDestino.SelectedIndex;

            var depositante = contas[indiceDepositante];
            var destino = contas[indiceDestino];

            double valor = Convert.ToDouble(textoValor.Text);

            depositante.Deposito(destino, valor);
        }

        private void FormDeposito_Load(object sender, EventArgs e)
        {

        }
    }
}
