using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCaelum
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set;  }
        public string Tipo { get; set; }

        private static int numeroDeContas;


        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public Conta(int numero)
        {
            this.Numero = numero;
        }

        public abstract void Sacar(double valor);

        public abstract void Depositar(double valor);
       


        public bool Transferir(Conta favorecido, double valor)
        {

            if(Saldo >= valor || Saldo != 0.00)
            {

                this.Sacar(valor);
                favorecido.Depositar(valor);

                return true;

            }
            
            
            return false;


        }


        public static int ProximaConta()
        {
            return numeroDeContas + 1;
        }

    }
}
