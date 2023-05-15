using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string res1 = "";
            do
            {
                Console.WriteLine("Selecciona alguna opcion:");
                Console.WriteLine("1. Ingresar dos números y luego calcular la suma, resta, multiplicación y división de los mismos.");
                Console.WriteLine("2. Ingresar un número entero y luego mostrar si el número es par o impar.");
                Console.WriteLine("3. Ingresar una cadena de texto y luego mostrar el número de caracteres que tiene la cadena.");
                Console.WriteLine("4. Ingresar una lista de números y luego mostrar el promedio de los mismos.");
                Console.WriteLine("5. Ingresar un número entero y luego mostrar todos los números primos que son menores o iguales a ese número.");
                Console.Write("Opcion: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                switch (numero)
                {
                    case 1:
                        // ejercicio 1
                        Console.Write("Introduce el primer número: ");
                        double nu1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introduce el segundo número: ");
                        double nu2 = Convert.ToDouble(Console.ReadLine());

                        double suma = nu1 + nu2;
                        double resta = nu1 - nu2;
                        double multiplicacion = nu1 * nu2;
                        double division = nu1 / nu2;

                        Console.WriteLine("La suma de los números es: " + suma);
                        Console.WriteLine("La resta de los números es: " + resta);
                        Console.WriteLine("La multiplicación de los números es: " + multiplicacion);
                        Console.WriteLine("La división de los números es: " + division);
                        break;
                    case 2:
                        // ejercicio 2
                        Console.Write("Introduce un número entero: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 % 2 == 0)
                        {
                            Console.WriteLine("El número es par");
                        }
                        else
                        {
                            Console.WriteLine("El número es impar");
                        }
                        break;
                    case 3:
                        // ejercicio 3
                        Console.Write("Introduce una cadena de texto: ");
                        string texto = Console.ReadLine();
                        int longitud = texto.Length;
                        Console.WriteLine("La cadena " + texto + " tiene " + longitud + " caracteres.");
                        break;
                    case 4:
                        // ejercicios 4
                        Console.Write("Introduce la cantidad de números a ingresar: ");
                        int cantidad1 = Convert.ToInt32(Console.ReadLine());
                        double suma1 = 0;
                        for (int i = 1; i <= cantidad1; i++)
                        {
                            Console.Write("Introduce el número " + i + ": ");
                            double numero1 = Convert.ToDouble(Console.ReadLine());
                            suma1 += numero1;
                        }
                        double promedio = suma1 / cantidad1;
                        Console.WriteLine("El promedio de los números ingresados es: " + promedio);
                        break;
                    case 5:
                        // ejercicio 5
                        Console.Write("Ingrese un número entero: ");
                        int numer1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Los números primos menores o iguales a " + numer1 + " son:");
                        for (int i = 2; i <= numer1; i++)
                        {
                            bool esPrimo = true;
                            for (int j = 2; j <= Math.Sqrt(i); j++)
                            {
                                if (i % j == 0)
                                {
                                    esPrimo = false;
                                    break;
                                }
                            }
                            if (esPrimo)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no válida");
                        break;
                }
                Console.WriteLine("¿Desea realizar otro ejercicio? (si/no)");
                res1 = Console.ReadLine();
            } while (res1 == "si");
            Console.ReadKey();  
        }
    }
}
