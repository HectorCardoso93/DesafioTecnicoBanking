using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Objetos
{
    public class ContaCorrente : Conta
    {
        private DateTime dataUltimaOperacao;
        private bool operacaoGratuitaNoMes;
        public ContaCorrente()
        {
            dataUltimaOperacao = DateTime.MinValue;
            operacaoGratuitaNoMes = true;
        }
        //A conta corrente tem um limite de cheque especial(por padrão R$ 300,00)
        public double ChequeEspecial { get => 300.00; }
        private bool VerificarPrimeiraOperacaoMes()
        {
            DateTime dataAtual = DateTime.Now;
            if(dataUltimaOperacao.Month != dataAtual.Month || dataUltimaOperacao.Year != dataAtual.Year)
            {
                dataUltimaOperacao = dataAtual;
                return operacaoGratuitaNoMes = true;
            } else
            {
                return operacaoGratuitaNoMes = false;
            }
        }

        //    Cada operação em conta corrente tem um custo, a primeira operação de cada mês não tem custo, os valores são:
        //    Deposito: Grátis
        public override void Deposito(ContaCorrente destino, double valor)
        {
            
        }
        //    Saque: R$ 4,77
        public override void Saque(double valor)
        {
            bool operacao = VerificarPrimeiraOperacaoMes();
            double saldoTotal = this.Saldo + ChequeEspecial;
            double operacaoSaque = 4.77;
            if (operacao == true)
            {
                //Qual o valor sacado
                if (saldoTotal > valor)
                {
                    this.Saldo -= valor;
                    MessageBox.Show($"Você sacou R${valor} e seu saldo foi para {this.Saldo.ToString("F")}.");
                }
                else
                {
                    MessageBox.Show("Valor do saque é maior que o seu saldo");
                }
                //As operações de saque não podem exceder o saldo mais o limite de cheque especial
            }
            else
            {
                if (saldoTotal > valor)
                {
                    this.Saldo -= (valor + operacaoSaque); 
                    MessageBox.Show($"Você sacou R${valor}.");
                    MessageBox.Show($"A operação de saque foi descontado {operacaoSaque} e seu saldo foi para {this.Saldo.ToString("F")}");
                }
                else
                {
                    MessageBox.Show("Valor do saque é maior que o seu saldo");
                }
            }
        }
        //    Transferencia: R$ 2,25
        public override void Transferencia(Conta destino, double valor)
        {
            bool operacao = VerificarPrimeiraOperacaoMes();
            if (operacao == true)
            {
                //Qual o valor sacado
                if (destino.Agencia == this.Agencia)
                {
                    this.Saldo -= valor;
                }
                else
                {
                    MessageBox.Show("A operação não pode ser concluída pois não são do mesmo banco.");
                }
                //As operações de saque não podem exceder o saldo mais o limite de cheque especial
            }
            else
            {
                if (destino.Agencia == this.Agencia)
                {
                    this.Saldo -= (valor + 2.25);
                }
                else
                {
                    MessageBox.Show("A operação não pode ser concluída pois não são do mesmo banco.");
                }
            }
            //Conta destino da transferencia(sempre será no mesmo banco)
            this.Saldo -= (valor + 2.25);
            //Qual o valor transferido
        }
        //    Extrato: R$ 3,82
        public override void Extrato()
        {
            bool operacao = VerificarPrimeiraOperacaoMes();
            if (operacao == true)
            {
                MessageBox.Show("Primeira operação do mês é gratuito.");
            }
            else
            {
                this.Saldo -= 3.82;
            }
        }
        //    Consultar Saldo: R$ 1,37
        public override void ConsultarSaldo()
        {
            double operacaoConsultaSaldo = 1.37;
            bool operacao = VerificarPrimeiraOperacaoMes();
            if (operacao == true)
            {
                MessageBox.Show("Primeira operação do mês é gratuito.");
                MessageBox.Show($"Seu saldo é de {this.Saldo.ToString("F")}");
            }
            else
            {
                this.Saldo -= operacaoConsultaSaldo;
                MessageBox.Show($"A operação de saque foi feita e seu saldo é de {this.Saldo.ToString("F")}");
            }
        }
        //      As operações com CUSTO devem ser debitadas tendo saldo ou não
    }
}
