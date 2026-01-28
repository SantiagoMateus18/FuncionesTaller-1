using System;
using System.Collections.Generic;

namespace FuncionesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludar();
            MostrarNumero(10);
            Console.WriteLine(Sumar(5, 3));
            MostrarMensaje("Hola mundo");
            Console.WriteLine(EsMayorDeEdad(20));
            Console.WriteLine(CalcularAreaCirculo(5));
            ImprimirArray(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(ObtenerLongitud("Alejandro"));
            MostrarPersona(new Persona("Juan", 25));
            Console.WriteLine(ObtenerMayor(10, 50));
            ImprimirLista(new List<string> { "A", "B", "C" });
            Console.WriteLine(ConvertirAMayusculas("hola"));
            MostrarFechaActual();
            Console.WriteLine(Promedio(new double[] { 3.5, 4.0, 5.0 }));
            Console.WriteLine(ContarCaracteres("ChatGPT"));
            MostrarDiccionario();
            Console.WriteLine(EsPar(8));
            MostrarMultiplicacion(5, 4);
            Console.WriteLine(Concatenar("Hola", "Mundo"));
            SaludoPersonalizado("Mar");
        }

        // 1. Sin parámetros, sin retorno
        static void Saludar()
        {
            Console.WriteLine("Hola!");
        }

        // 2. Con parámetro, sin retorno
        static void MostrarNumero(int numero)
        {
            Console.WriteLine(numero);
        }

        // 3. Con parámetros, con retorno
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        // 4. Parámetro string, sin retorno
        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        // 5. Retorna boolean
        static bool EsMayorDeEdad(int edad)
        {
            return edad >= 18;
        }

        // 6. Retorna double
        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        // 7. Array como parámetro
        static void ImprimirArray(int[] numeros)
        {
            foreach (var n in numeros)
                Console.WriteLine(n);
        }

        // 8. String como parámetro y retorno
        static int ObtenerLongitud(string texto)
        {
            return texto.Length;
        }

        // 9. Clase como parámetro
        static void MostrarPersona(Persona persona)
        {
            Console.WriteLine($"{persona.Nombre} - {persona.Edad} años");
        }

        // 10. Retorna el mayor de dos números
        static int ObtenerMayor(int a, int b)
        {
            return a > b ? a : b;
        }

        // 11. Lista como parámetro
        static void ImprimirLista(List<string> lista)
        {
            foreach (var item in lista)
                Console.WriteLine(item);
        }

        // 12. Retorna string
        static string ConvertirAMayusculas(string texto)
        {
            return texto.ToUpper();
        }

        // 13. Sin parámetros, sin retorno
        static void MostrarFechaActual()
        {
            Console.WriteLine(DateTime.Now);
        }

        // 14. Array double con retorno
        static double Promedio(double[] valores)
        {
            double suma = 0;
            foreach (var v in valores)
                suma += v;
            return suma / valores.Length;
        }

        // 15. Retorna int
        static int ContarCaracteres(string texto)
        {
            return texto.Length;
        }

        // 16. Diccionario sin parámetros
        static void MostrarDiccionario()
        {
            Dictionary<string, int> edades = new Dictionary<string, int>()
            {
                { "Ana", 20 },
                { "Luis", 30 }
            };

            foreach (var item in edades)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }

        // 17. Retorna boolean
        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }

        // 18. Múltiples parámetros sin retorno
        static void MostrarMultiplicacion(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        // 19. Retorna string
        static string Concatenar(string a, string b)
        {
            return a + " " + b;
        }

        // 20. Parámetro string, sin retorno
        static void SaludoPersonalizado(string nombre)
        {
            Console.WriteLine($"Hola {nombre}, bienvenido!");
        }
    }
}
