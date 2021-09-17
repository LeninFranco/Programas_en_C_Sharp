using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoBasico
{
    class Cuenta
    {
        private double saldo;

        public Cuenta(double saldoInicial)
        {
            if (saldoInicial >= 0) this.saldo = saldoInicial;
            else this.saldo = 0;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo(double nuevoSaldo)
        {
            this.saldo = nuevoSaldo;
        }

        public void Retirar(double monto)
        {
            this.saldo -= monto;
        }

        public void Depositar(double monto)
        {
            this.saldo += monto;
        }

        public override string ToString()
        {
            return "Saldo: $" + this.saldo;
        }
    }
}
