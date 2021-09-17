using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancoBasico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opc1, opc2;
            string Nombre, NCuenta, Saldo, Monto;
            Banco banco = new Banco();
            do
            {
                Console.Clear();
                opc1 = MenuBanco();
                Console.WriteLine("\n");
                switch (opc1)
                {
                    case 1:
                        Console.Write("-> Ingrese el Numero de Cuenta: ");
                        NCuenta = Console.ReadLine();
                        Console.Write("-> Ingrese el Nombre del Cliente: ");
                        Nombre = Console.ReadLine();
                        Console.Write("-> Ingrese el Saldo inicial: $");
                        Saldo = Console.ReadLine();
                        if(isInteger(NCuenta) && isDouble(Saldo))
                        {
                            if (!banco.Exists(int.Parse(NCuenta)))
                            {
                                banco.Add(int.Parse(NCuenta), new Cliente(Nombre, new Cuenta(double.Parse(Saldo))));
                                Console.WriteLine("-> ¡Se añadio el cliente exitosamente!");
                            }
                            else
                            {
                                Console.WriteLine("-> Ya existe el cliente con el numero de cuenta: "+ NCuenta);
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Favor de ingresar datos correctos");
                        }
                        Pause();
                        break;
                    case 2:
                        Console.Write("-> Ingrese el Numero de Cuenta: ");
                        NCuenta = Console.ReadLine();
                        if (isInteger(NCuenta))
                        {
                            if (banco.Exists(int.Parse(NCuenta)))
                            {
                                Console.WriteLine("-> ¡Se ha encontrado al cliente exitosamente!");
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine(banco.FindOne(int.Parse(NCuenta)));
                                Console.WriteLine("----------------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("-> No se ha encontrado al cliente");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Favor de ingresar datos correctos");
                        }
                        Pause();
                        break;
                    case 3:
                        Console.Write("-> Ingrese el Numero de Cuenta: ");
                        NCuenta = Console.ReadLine();
                        if (isInteger(NCuenta))
                        {
                            if (banco.Exists(int.Parse(NCuenta)))
                            {
                                banco.Remove(int.Parse(NCuenta));
                                Console.WriteLine("-> ¡Se elimino el cliente exitosamente!");
                            }
                            else
                            {
                                Console.WriteLine("-> No se ha encontrado al cliente a eliminar");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Favor de ingresar datos correctos");
                        }
                        Pause();
                        break;
                    case 4:
                        Console.Write("-> Ingrese el Numero de Cuenta: ");
                        NCuenta = Console.ReadLine();
                        if (isInteger(NCuenta))
                        {
                            if (banco.Exists(int.Parse(NCuenta)))
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.WriteLine("-> ¡Saludos " + banco.FindOne(int.Parse(NCuenta)).GetNombre() + "!");
                                    opc2 = MenuCliente();
                                    Console.WriteLine("\n");
                                    switch (opc2)
                                    {
                                        case 1:
                                            Console.Write("-> Ingrese el Monto a Depositar: $");
                                            Monto = Console.ReadLine();
                                            if (isDouble(Monto))
                                            {
                                                if (double.Parse(Monto) > 0)
                                                {
                                                    banco.FindOne(int.Parse(NCuenta)).GetCuenta().Depositar(double.Parse(Monto));
                                                    Console.WriteLine("-> ¡Se ha depositado el monto exitosamente!");
                                                    Console.WriteLine("-> Saldo Actual: " + banco.FindOne(int.Parse(NCuenta)).GetCuenta().GetSaldo());
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-> Favor de ingresar valores positivos");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("-> Favor de ingresar datos correctos");
                                            }
                                            Pause();
                                            break;
                                        case 2:
                                            Console.Write("-> Ingrese el Monto a Retirar: $");
                                            Monto = Console.ReadLine();
                                            if (isDouble(Monto))
                                            {
                                                if (double.Parse(Monto) > 0)
                                                {
                                                    if(double.Parse(Monto) < banco.FindOne(int.Parse(NCuenta)).GetCuenta().GetSaldo())
                                                    {
                                                        banco.FindOne(int.Parse(NCuenta)).GetCuenta().Retirar(double.Parse(Monto));
                                                        Console.WriteLine("-> ¡Se ha retirado el monto exitosamente!");
                                                        Console.WriteLine("-> Saldo Actual: " + banco.FindOne(int.Parse(NCuenta)).GetCuenta().GetSaldo());
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("-> No se tiene el suficiente efectivo para retirar");
                                                        Console.WriteLine("-> Saldo Actual: " + banco.FindOne(int.Parse(NCuenta)).GetCuenta().GetSaldo());
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("-> Favor de ingresar valores positivos");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("-> Favor de ingresar datos correctos");
                                            }
                                            Pause();
                                            break;
                                        case 3:
                                            Console.WriteLine("-> Saldo Actual: $" + banco.FindOne(int.Parse(NCuenta)).GetCuenta().GetSaldo());
                                            Pause();
                                            break;
                                    }
                                } while (opc2 != 4);
                                Console.WriteLine("-> ¡Adios " + banco.FindOne(int.Parse(NCuenta)).GetNombre() + "!");
                            }
                            else
                            {
                                Console.WriteLine("-> No se ha encontrado al cliente");
                            }
                        }
                        else
                        {
                            Console.WriteLine("-> Favor de ingresar datos correctos");
                        }
                        Pause();
                        break;
                    case 5:
                        banco.FindAll();
                        Pause();
                        break;
                }
            } while (opc1 != 6);
            Console.WriteLine("-> Gracias por Usarme UwU");
            Pause();
        }

        private static void Pause()
        {
            Console.Write("-> Presione ENTER para continuar...");
            Console.ReadKey();
        }

        private static int MenuBanco()
        {
            Console.WriteLine("***********MENU DEL BANCO***********");
            Console.WriteLine("************************************");
            Console.WriteLine("* 1. Añadir Cliente                *");
            Console.WriteLine("* 2. Buscar Cliente                *");
            Console.WriteLine("* 3. Eliminar Cliente              *");
            Console.WriteLine("* 4. Operaciones de un Cliente     *");
            Console.WriteLine("* 5. Mostrar a todos los Clientes  *");
            Console.WriteLine("* 6. Salir                         *");
            Console.WriteLine("************************************");
            Console.Write("-> Opcion: ");
            string opc = Console.ReadLine();
            return isInteger(opc) ? int.Parse(opc) : 0;
        }

        private static int MenuCliente()
        {
            Console.WriteLine("**********MENU DEL CLIENTE**********");
            Console.WriteLine("************************************");
            Console.WriteLine("* 1. Depositar Dinero              *");
            Console.WriteLine("* 2. Retirar Dinero                *");
            Console.WriteLine("* 3. Consultar Saldo               *");
            Console.WriteLine("* 4. Regresar                      *");
            Console.WriteLine("************************************");
            Console.Write("-> Opcion: ");
            string opc = Console.ReadLine();
            return isInteger(opc) ? int.Parse(opc) : 0;
        }

        private static bool isDouble(string numero)
        {
            try
            {
                double.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool isInteger(string numero)
        {
            try
            {
                int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
