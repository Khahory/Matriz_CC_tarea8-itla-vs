using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_CC_tarea8
{
    class Program
    {
        private int[,] matriz_n;
        private int size, cont, nodo_P;

        static void Main(string[] args)
        {
            Program objeto = new Program();
            objeto.PedirTamanio_m(); objeto.Agregar_matriz(); objeto.Mostrar_m(); objeto.Calcular_CC();
        }


        public void Agregar_matriz()
        {
            for (int a = 0; a < size; a++)
            {
                for (int b = 0; b < size; b++)
                {
                    Console.Write("Digite los datos por la columna " + "[" + a + "," + b + "] = ");
                    string linea = Console.ReadLine(); matriz_n[a, b] = int.Parse(linea);
                }
            }
        }

        public void PedirTamanio_m()
        {
            Console.Write("Digite el size de la matriz"); size = int.Parse(Console.ReadLine()); matriz_n = new int[size, size];
        }


        public void Calcular_CC()
        {
            for (int a = 0; a < size; a++)
            {
                for (int c = 0; c < size; c++)
                {
                    if (matriz_n[a, c] == 1)
                    {
                        cont++;
                    }
                }
                if (cont > 1 && cont % 2 == 0)
                {
                    nodo_P++;
                }
                else
                {
                    cont -= 1;
                    if (cont > 1 && cont % 2 == 0)
                    {
                        nodo_P++;
                    }
                }
                cont = 0;
            }
            Console.Write("El calculo ciclomatico: " + (nodo_P + 1)); Console.ReadLine();
        }

        public void Mostrar_m()
        {
            Console.WriteLine("Aqui mostramos la representacion de la matriz");
            for (int a = 0; a < size; a++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write(matriz_n[a, c] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
