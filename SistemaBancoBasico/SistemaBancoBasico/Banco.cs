using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoBasico
{
    class Banco
    {
        private Hashtable clientes;

        public Banco()
        {
            clientes = new Hashtable();
        }

        public void Add(int NumeroCuenta, Cliente cliente)
        {
            clientes.Add(NumeroCuenta, cliente);
        }

        public void Remove(int NumeroCuenta)
        {
            clientes.Remove(NumeroCuenta);
        }

        public bool Exists(int NumeroCuenta)
        {
            return clientes.ContainsKey(NumeroCuenta);
        }

        public Cliente FindOne(int NumeroCuenta)
        {
            if (Exists(NumeroCuenta))
            {
                return (Cliente)clientes[NumeroCuenta];
            }
            else
            {
                return null;
            }
        }

        public void FindAll()
        {
            ArrayList listaTemp = new ArrayList(clientes.Keys);
            listaTemp.Sort();
            for (int i = 0; i < listaTemp.Count; i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Numero de Cuenta: " + listaTemp[i]);
                Console.WriteLine(clientes[listaTemp[i]]);
                Console.WriteLine("----------------------------------------");
            }
        }
    }
}
