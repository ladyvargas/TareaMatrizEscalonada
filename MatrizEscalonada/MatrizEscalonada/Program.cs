using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEscalonada
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] m1 = new int[4][][];//TAREA MULTIPLICAR MATRIZ
            inicializar(m1);
            Console.ReadKey();
        }
        public static void inicializar(int [][][] matriz)
        {
            for (int i = 0; i < 4; i++)
            {
                matriz[i] = new int[3][];
                for (int j = 0; j < 3; j++)
                {
                    matriz[i][j] = new int[3];
                }
            }
            Console.WriteLine("\nMultiplicación de matrices utilizando dimensiones escalonada y rectangular");
            leer(matriz[0]);//lectura primera matriz
            leer(matriz[1]);//lectura segunda matriz
            leer(matriz[2]);//lectura tercera matriz
            multiplicar(matriz[0], matriz[1], matriz[2], matriz[3]);
        }

        public static void multiplicar(int[][] A, int[][] B, int[][] C, int[][] D)
        {
            int[][] aux = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                aux[i] = new int[3];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    aux[i][j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                    aux[i][j] = aux[i][j] + A[i][k] * B[k][j];
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    D[i][j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        D[i][j] = D[i][j] + aux[i][k] * C[k][j];
                    }
                }
            }
            imprimir(D);
        }
        public static void leer(int[][] matriz)
        {
            Console.WriteLine("\nIngrese los elementos de la matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string aux;
                    Console.Write(" [ {0}][{1} ] ", i, j);
                    aux = Console.ReadLine();
                    matriz[i] [j] = Int32.Parse(aux);
                }
                Console.WriteLine();
            }
            imprimir(matriz);
        }
        public static void imprimir(int[][] matriz)
        {
            Console.WriteLine("\nImpresión de la matriz");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", matriz[i] [j]);
                }
                Console.WriteLine();
            }
        }
    }
}
