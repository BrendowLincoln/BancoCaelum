using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaInvestimento : Conta, ITributavel
    {
        

        public override bool Depositar(double valor)
        {
            if (valor != 0 && valor > 0)
            {

                Saldo += valor;
                return true;
            }

            return false;
        }

        public override bool Sacar(double valor)
        {
            if (valor != 0 && valor <= this.Saldo)
            {

                this.Saldo -= (valor + 0.05);
                return true;

            }

            return false;
        }
        public double CalcularTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
