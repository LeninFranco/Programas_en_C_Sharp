using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoBasico
{
    class Cliente
    {
        private string Nombre;
        private Cuenta cuenta;
        
        public Cliente(string Nombre, Cuenta cuenta)
        {
            this.Nombre = Nombre;
            this.cuenta = cuenta;
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public Cuenta GetCuenta()
        {
            return this.cuenta;
        }

        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\n" + this.cuenta;
        }
    }
}
