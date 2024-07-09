using DesafioTecnicoBanking.Objetos;

namespace DesafioTecnicoBanking
{
    public partial class Form1 : Form
    {
        private List<Conta> Contas { get; set; } = new List<Conta>();
        public void AdicionarConta(Conta conta)
        {
            this.Contas.Add(conta);
            comboContas.Items.Add(conta);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoAdicionarConta_Click(object sender, EventArgs e)
        {
            FormNovaConta formularioNovaConta = new FormNovaConta(this);
            formularioNovaConta.ShowDialog();
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            FormDeposito formularioDeposito = new FormDeposito(this);
            formularioDeposito.SetTitulares(Contas);
            formularioDeposito.ShowDialog();
        }

        private void botaoSaldo_Click(object sender, EventArgs e)
        {
            FormConsultaSaldo formularioConsulta = new FormConsultaSaldo(this);
            formularioConsulta.SetTitulares(Contas);
            formularioConsulta.ShowDialog();
        }

        private void botaoExtrato_Click(object sender, EventArgs e)
        {
            FormExtrato formularioExtrato = new FormExtrato(this);
            formularioExtrato.ShowDialog();
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            FormSaque formularioSaque = new FormSaque(this);
            formularioSaque.SetTitulares(Contas);
            formularioSaque.ShowDialog();
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            FormTransferencia formularioTransferencia = new FormTransferencia(this);
            formularioTransferencia.SetTitulares(Contas);
            formularioTransferencia.ShowDialog();
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = Contas[indice];
            textoAgencia.Text = Convert.ToString(selecionada.Agencia);
            textoNumeroConta.Text = Convert.ToString(selecionada.NumeroConta);
            textoTitular.Text = selecionada.Titular.Nome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
