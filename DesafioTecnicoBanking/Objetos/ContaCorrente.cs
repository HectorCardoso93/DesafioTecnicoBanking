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
        public override void Deposito(Conta destino, double valor)
        {
            base.Deposito(destino, valor);
        }
        //    Saque: R$ 4,77
        public override void Saque(double valor)
        {
            bool operacao = VerificarPrimeiraOperacaoMes();
            double operacaoSaque = 4.77;
            if (operacao)
            {
                base.Saque(valor);
                //Qual o valor sacado
                
                //As operações de saque não podem exceder o saldo mais o limite de cheque especial
            }
            else
            {
                if (this.SaldoTotal > valor)
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
            double operacaoTransferencia = 2.25;
            if (operacao)
            {
                //Qual o valor sacado
                base.Transferencia(destino, valor);
                //As operações de saque não podem exceder o saldo mais o limite de cheque especial
            }
            else
            {
                if (destino.Agencia == this.Agencia)
                {
                    this.Saldo -= (valor + operacaoTransferencia);
                }
                else
                {
                    MessageBox.Show("A operação não pode ser concluída pois não são do mesmo banco.");
                }
            }
            //Conta destino da transferencia(sempre será no mesmo banco)
            //Qual o valor transferido
        }
        //    Extrato: R$ 3,82
        public override void Extrato()
        {
            bool operacao = VerificarPrimeiraOperacaoMes();
            double operacaoExtrato = 3.82;
            if (operacao)
            {
                MessageBox.Show("Primeira operação do mês é gratuito.");
            }
            else
            {
                this.Saldo -= operacaoExtrato;
            }
        }
        //    Consultar Saldo: R$ 1,37
        public override void ConsultarSaldo()
        {
            double operacaoConsultaSaldo = 1.37;
            bool operacao = VerificarPrimeiraOperacaoMes();
            if (operacao)
            {
                base.ConsultarSaldo();
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
