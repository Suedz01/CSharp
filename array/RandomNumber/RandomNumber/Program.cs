using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Randomizar x valores diferentes

            Random r = new Random();
            int n;

            Console.WriteLine("Quanto números aleatórios?");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int var = r.Next(0, 1000);
                Console.WriteLine(var);
            }
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }
    }
}
