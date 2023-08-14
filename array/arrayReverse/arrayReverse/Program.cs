using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //SWAP
            int[] array;
            int n;

            Console.WriteLine("Insira o tamanho do array: ");
            n = int.Parse(Console.ReadLine());
            array = new int[n];

            Console.Clear();
            Console.WriteLine("Preencha o vetor:\n");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Pressione ENTER para prosseguir:");
            Console.ReadLine();

            for(int i = 0; i< array.Length/2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            //plotando array invertido
            Console.Write("Array invertido com sucesso:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nPressione ENTER para sair:");
            Console.ReadLine();

        }
    }
}
