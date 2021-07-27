using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaCorrente : Conta, ITributavel
    {

        private static int totalDeContas;
           int proxima = ContaCorrente.ProximaConta();


        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        
        public double CalcularTributo()
        {
            return this.Saldo * 0.05;
        }

        public override void Depositar(double valor)
        {
            if (valor != 0 && valor > 0)
            {

                Saldo += valor;
            }

        }

        public override void Sacar(double valor)
        {


            if (valor != 0 && valor <= this.Saldo)
            {

                this.Saldo -= (valor + 0.05);

            }


        }

        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }


    }
}
  