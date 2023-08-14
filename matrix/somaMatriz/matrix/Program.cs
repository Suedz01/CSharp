using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soma entre matrizes
            int m, n;

            Console.WriteLine("Insira a seguir o tamanho da sua variável: m x n");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[m, n];

            Console.WriteLine("Agora, vamos preencher a primeira matriz!");
            preencherMatrix(matrix1,m,n);
            plotarMatrix(matrix1, m, n);

            Console.WriteLine("Agora, vamos preencher a segunda matriz!");
            int[,] matrix2 = new int[m, n];
            preencherMatrix(matrix2, m, n);
            plotarMatrix(matrix2, m, n);

            Console.WriteLine("Por fim, vamos somar as matrizes 1 e 2:");
            int[,] matrix3 = new int[m, n];
            somarMatrix(matrix1, matrix2, matrix3, m, n);

            Console.WriteLine("#Matriz 1:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}] ", matrix1[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("#Matriz 2:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}] ", matrix2[i, j]);
                }
                Console.WriteLine("\n");
            }

            Console.Write("\n===========");
            Console.Write("\nResultado:");
            plotarMatrix(matrix3, m, n);
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

        static void plotarMatrix(int[,] A,int m,int n)
        {
            Console.Write("\n\n");
            Console.WriteLine("#Matriz Preenchida:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("[{0}] ", A[i,j]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Pressione ENTER para prosseguir...");
            Console.ReadLine();
            Console.Clear();
        }

        static void somarMatrix(int[,] A, int[,] B, int[,] C, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i,j] + B[i,j];
                }
            }
        }
    }
}
