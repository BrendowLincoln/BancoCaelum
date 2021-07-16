using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    class ContaPoupanca : Conta 
    {

<<<<<<< HEAD
        public ContaPoupanca(int numero = 0):  base (numero) { }
=======
        public ContaPoupanca(int numero):  base (numero) { }
>>>>>>> 4719504bd169c8dd531c9e4b1be1100e8a806801
       

        public override bool Sacar(double valor)
        {

            return base.Sacar(valor + 0.10);

        }

    }
}
