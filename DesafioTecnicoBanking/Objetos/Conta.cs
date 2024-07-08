using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Objetos
{
    public class Conta
    {
        private static int numeroConta;
        public Conta()
        {
            Conta.numeroConta++;
            this.NumeroConta = Conta.numeroConta;
        }
        public int ProximoNumeroConta()
        {
            return Conta.numeroConta + 1;
        }
        public override String ToString()
        {
            return "Titular: " + this.Titular.Nome;
        }
        public int NumeroConta { get; internal set; }
        public int Agencia { get => 100; }
        //public double Saldo { get; set; }
        public Pessoa Titular { get; set; }
        public double Saldo { get; internal set; }
        public virtual void Deposito (ContaCorrente destino, double valor)
        {
            //Quem foi o Depositante

            //Qual conta destino do deposito

            //Qual o valor depositado
            if(valor > 0)
            {
                destino.Saldo += valor;
                this.Saldo -= valor;
                MessageBox.Show($"Deposito efetuado com sucesso de {this.Titular.Nome} para {destino.Titular.Nome} no valor de R${valor.ToString("F")}");
            } else
            {
                MessageBox.Show("Saldo é inferior ao valor depositado.");
            }
        }
        public virtual void ConsultarSaldo() 
        {
            //MessageBox.Show($"Seu saldo é de {this.Saldo}");
        }
        public virtual void Extrato()
        {

        }
        public virtual void Saque(double valor)
        {
            //Qual o valor sacado
            double saldoTotal = this.Titular.Saldo + 300;
            if(saldoTotal > valor)
            {
                this.Titular.Saldo -= valor;
            } else
            {
                MessageBox.Show("Valor do saque é maior que o seu saldo");
            }
            //As operações de saque não podem exceder o saldo mais o limite de cheque especial
        }
        public virtual void Transferencia(Conta destino, double valor)
        {
            //Conta destino da transferencia(sempre será no mesmo banco)
            if(destino.Agencia == this.Agencia)
            {
                this.Titular.Saldo -= valor;
                destino.Saldo += valor;
            }
            else
            {
                MessageBox.Show("A operação não pode ser concluída pois não são do mesmo banco.");
            }
            //Qual o valor transferido
        }
    }
}
