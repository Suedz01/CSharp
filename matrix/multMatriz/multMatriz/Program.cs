using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, n1, m2, n2;
            bool compativel = false;
            int[,] matriz3;

            Console.WriteLine("Qual será o tamanho da matriz 1:\nLinhas x Colunas");
            m1 = int.Parse(Console.ReadLine());
            n1 = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[m1, n1];
            preencherMatrix(matriz1, m1, n1);

            do
            {
                Console.Clear();
                Console.WriteLine("Qual será o tamanho da matriz 2:\nLinhas x Colunas");
                Console.WriteLine("*O número de linhas precisa ser igual ao número de colunas!*");

                m2 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());

                compativel = m1 == n2 || n1 == m2;
                Console.WriteLine(compativel);
            } while ( !compativel );
            
            int[,] matriz2 = new int[m2, n2];
            preencherMatrix(matriz2, m2, n2);
            Console.Clear();

            Console.WriteLine("\n\nMatriz 1: ");
            plotarMatrix(matriz1, m1, n1);
            Console.WriteLine("\n\nMatriz 2: ");
            plotarMatrix(matriz2, m2, n2);

            matriz3 = multMatriz(matriz1, matriz2);
            Console.WriteLine("\n\nMatriz resultante: ");
            plotarMatrix(matriz3, matriz1.GetLength(0), matriz2.GetLength(1));
        }

        static int[,] multMatriz( int[,] A, int[,] B )
        {
            int[,] result = new int[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return result;
        }

        static void preencherMatrix(int[,] A, int m, int n)
        {
            Console.WriteLine("\n#Preencha:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("M[{0}] N[{1}]", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static void plotarMatrix(int[,] A, int m, int n)
        {
            Console.Write("\n");
            Console.WriteLine("#Matriz Preenchida:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}] ", A[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Pressione ENTER para prosseguir...");
            Console.ReadLine();
        }

        static void somarMatrix(int[,] A, int[,] B, int[,] C, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
        }
    }
}
