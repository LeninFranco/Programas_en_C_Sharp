using System;

namespace CalculadoraBasica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string temp, num1, num2;
            int opc;
            double resultado;
            do
            {
                Console.Clear();
                MenuPrincipal();
                temp = Console.ReadLine();
                if (isInteger(temp)) opc = int.Parse(temp);
                else opc = 0;
                Console.WriteLine("\n");
                switch (opc)
                {
                    case 1:
                        Console.Write("->Ingrese el primer numero: ");
                        num1 = Console.ReadLine();
                        Console.Write("->Ingrese el segundo numero: ");
                        num2 = Console.ReadLine();
                        if (isDouble(num1) && isDouble(num2))
                        {
                            resultado = double.Parse(num1) + double.Parse(num2);
                            Console.WriteLine("->El resultado es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                    case 2:
                        Console.Write("->Ingrese el primer numero: ");
                        num1 = Console.ReadLine();
                        Console.Write("->Ingrese el segundo numero: ");
                        num2 = Console.ReadLine();
                        if (isDouble(num1) && isDouble(num2))
                        {
                            resultado = double.Parse(num1) - double.Parse(num2);
                            Console.WriteLine("->El resultado es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                    case 3:
                        Console.Write("->Ingrese el primer numero: ");
                        num1 = Console.ReadLine();
                        Console.Write("->Ingrese el segundo numero: ");
                        num2 = Console.ReadLine();
                        if (isDouble(num1) && isDouble(num2))
                        {
                            resultado = double.Parse(num1) * double.Parse(num2);
                            Console.WriteLine("->El resultado es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                    case 4:
                        Console.Write("->Ingrese el primer numero: ");
                        num1 = Console.ReadLine();
                        Console.Write("->Ingrese el segundo numero: ");
                        num2 = Console.ReadLine();
                        if (isDouble(num1) && isDouble(num2))
                        {
                            if(double.Parse(num2) != 0)
                            {
                                resultado = double.Parse(num1) / double.Parse(num2);
                                Console.WriteLine("->El resultado es: " + resultado);
                            }
                            else
                            {
                                Console.WriteLine("->No se puede dividir entre cero");
                            }
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                    case 5:
                        Console.Write("->Ingrese el primer numero: ");
                        num1 = Console.ReadLine();
                        Console.Write("->Ingrese el segundo numero: ");
                        num2 = Console.ReadLine();
                        if (isDouble(num1) && isDouble(num2))
                        {
                            resultado = Math.Pow(double.Parse(num1), double.Parse(num2));
                            Console.WriteLine("->El resultado es: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                    case 6:
                        Console.Write("->Ingrese el numero: ");
                        num1 = Console.ReadLine();
                        if (isDouble(num1))
                        {
                            if(double.Parse(num1) > 0)
                            {
                                resultado = Math.Sqrt(double.Parse(num1));
                                Console.WriteLine("->El resultado es: " + resultado);
                            }
                            else
                            {
                                Console.WriteLine("->No hay raiz cuadrada de numeros negativos");
                            }
                        }
                        else
                        {
                            Console.WriteLine("->Favor de ingresar datos validos");
                        }
                        break;
                }
                Pause();
            } while (opc != 7);
            Console.WriteLine("->Gracias por usarme UwU");
            Pause();
        }

        private static void Pause()
        {
            Console.Write("->Presione ENTER para continuar...");
            Console.ReadKey();
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

        private static void MenuPrincipal()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("* 1. Suma: (a+b)               *");
            Console.WriteLine("* 2. Resta: (a-b)              *");
            Console.WriteLine("* 3. Multiplicacion: (a x b)   *");
            Console.WriteLine("* 4. Division: (a/b)           *");
            Console.WriteLine("* 5. Potencia: (a^b)           *");
            Console.WriteLine("* 6. Raiz Cuadrada: sqrt(x)    *");
            Console.WriteLine("* 7. Salir                     *");
            Console.WriteLine("********************************");
            Console.Write("\n->Opcion: ");
        }
    }
}
