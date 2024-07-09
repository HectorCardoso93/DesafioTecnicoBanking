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
        private List<Conta> contas;
        private Form1 formPrincipal;
        public FormTransferencia(Form1 formPrincipal)
        {
            contas = new List<Conta>();
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        public void SetTitulares(List<Conta> titulares)
        {
            foreach (Conta titular in titulares)
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

            var contaRemetente = contas[indiceRemetente];
            var contaDestino = contas[indiceDestino];

            double valor = Convert.ToDouble(textoValor.Text);

            contaRemetente.Transferencia(contaDestino, valor);
        }
    }
}
