using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class TotalizadorDeContas
    {

        public double SaldoTotal { get; set; }


        public void Adiciona(Conta conta)
        {
            SaldoTotal += conta.Saldo;
        }


    }
}
