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
    public partial class FormTransferencia : Form
    {
        private List<ContaCorrente> contas;
        private Form1 formPrincipal;
        public FormTransferencia(Form1 formPrincipal)
        {
            contas = new List<ContaCorrente>();
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        public void SetTitulares(List<ContaCorrente> titulares)
        {
            foreach (ContaCorrente titular in titulares)
            {
                comboRemetente.Items.Add(titular);
                comboDestino.Items.Add(titular);
                contas.Add(titular);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {

        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            int indiceRemetente = comboRemetente.SelectedIndex;
            int indiceDestino = comboDestino.SelectedIndex;

            ContaCorrente contaRemetente = contas[indiceRemetente];
            ContaCorrente contaDestino = contas[indiceDestino];

            double valor = Convert.ToDouble(textoValor.Text);

            contaRemetente.Transferencia(contaDestino, valor);
        }
    }
}
