using System;

namespace EJERCICIOS
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Punto #1");
            // Console.WriteLine("Escriba un número cualquiera:");
            //int punto1;

            //punto1 = int.Parse(Console.ReadLine());

            //if ((punto1 % 2) == 0)
            // Console.WriteLine("Es Par")
            // else
            //  Console.WriteLine("Es Impar");
            ////  Console.WriteLine("Press enter to close...");
            /// Console.ReadLine();
            //

            // ---------------------------------------------------------------------------------
            //  Console.WriteLine("Punto #2");
            // Console.WriteLine("Escriba un número cualquiera:");

            // int punto2, i;

            // punto2 = int.Parse(Console.ReadLine());

            //   for (i = 1; i <= 10; i++)
            //   {
            ///      Console.WriteLine(punto2 + "x" + i + "=" + punto2 * i);
            // }

            //  Console.WriteLine("Press enter to close...");
            // Console.ReadLine();

            // Console.WriteLine("Punto #3");

            // int a, b;

            // for (a = 2; a <= 9; a++)
            //   {
            //      for (b = 1; b <= 10; b++)
            //   {
            //       Console.WriteLine(a + "x" + b + "=" + a * b);
            //  }
            //  }

            //   Console.WriteLine("Press enter to close...");
            //   Console.ReadLine();

        /*    Console.WriteLine("Punto #4");

            int a, i, c = 0;
            String afirmativo = "Es primo", negativo = "no es primo";

            Console.WriteLine("Escriba un número aleatorio:");

            a = int.Parse(Console.ReadLine());

            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    c++;
                }
            }
            if (c > 2)
            { Console.WriteLine(negativo); }
            else Console.WriteLine(afirmativo);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();//

            Console.WriteLine("5. Punto");
            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };

            for (int k = 0; k < edad.Length; k++)
            {
                for (int f = 0; f < edad.Length - 1; f++)
                {
                    if (edad[f] > edad[f + 1])
                    {
                        int aux;
                        aux = edad[f];
                        edad[f] = edad[f + 1];
                        edad[f + 1] = aux;
                    }
                }
            }
            for (int f = 0; f < edad.Length; f++)
            {
                Console.Write(edad[f] + "»");

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();

                Console.WriteLine("6. Punto");
                Console.WriteLine("escriba el nombre a consultar:");
                int c = 0;
                int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
                string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                string nombre = Console.ReadLine();

                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombre == nombres[i])
                    {
                        Console.WriteLine("la edad de " + nombre + " es " + edad[i]);
                        c++;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("No se encontró el nombre " + nombre + " en la lista");
                }
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
                Console.WriteLine("7. Punto");
                int mayor = 0, menor = 1000;
                string nma = "a", nme = "b";
                int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
                string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

                for (int i = 0; i < edad.Length; i++)
                {
                    if (edad[i] > mayor)
                    {
                        mayor = edad[i];
                        nma = nombres[i];
                    }
                    if (edad[i] < menor)
                    {
                        menor = edad[i];
                        nme = nombres[i];
                    }
                }

                Console.WriteLine("El menor es " + nme + " con " + menor + " años.");
                Console.WriteLine("El mayor es " + nma + " con " + mayor + " años.");

                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
            }
        }
    }
}


