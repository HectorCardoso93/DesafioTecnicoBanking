using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnicoBanking.Objetos
{
    public class ContaPoupanca : Conta
    {
        public override void Transferencia(Conta destino, double valor)
        {
            if(destino is ContaCorrente)
            {
                MessageBox.Show("Transferência de conta poupança para conta corrente não permitida.");
            } else
            {
                base.Transferencia(destino, valor);
            }
        }
    }
}
