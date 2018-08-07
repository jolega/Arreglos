using System;

// eliminacion de numeros duplicados usando arreglos de enteros
namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            //variables

            int[] arregloInicial;
            int[] arregloFinal;
            int cantidad;

            // solicita cantidad de datos

            Console.WriteLine("Listado de numeros, se eliminar los duplicados");

            Console.WriteLine("indique la cantidad de numeros a ingresar");
            cantidad = int.Parse(Console.ReadLine());
            arregloInicial = new int[cantidad];
            arregloFinal = new int[cantidad];

            // llenado del arreglo
            for (int i = 0; i < arregloInicial.Length; i++)
            {
                Console.WriteLine("ingrese el dato " + (i+1));
                arregloInicial[i] = int.Parse(Console.ReadLine());
            }


            imprimirArreglo(arregloInicial);
            

            //Eliminacion de duplicados
            for (int i = 0, j=0; i < arregloInicial.Length; i++)
            {
                if(buscar(arregloInicial[i], arregloFinal))
                {
                    arregloFinal[j]= arregloInicial[i];
                        j++;
                }

            }

            imprimirArreglo(arregloFinal);
            Console.ReadKey();



        }

        static void imprimirArreglo(int[] a)
        {
            String datos="";
            for (int i = 0; i < a.Length; i++)
            {

                datos += " " + a[i];

            }
            Console.WriteLine("" + datos);
        }

        static Boolean buscar(int a, int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {

                if (b[i] == a)
                {
                    return false;

                }

            }

            return true;


        }




    }
}
