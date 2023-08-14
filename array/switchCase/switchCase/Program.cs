using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;

            do
            {
                Console.WriteLine("Qual opção deseja acessar?");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Você escolheu a opção 1!");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu a opção 2!");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu a opção 3!");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu a opção 4!");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Você escolheu a opção 5!");
                        Console.ReadLine();
                        break;
                }
            } while (menu < 1 || menu > 5);
            
        }
    }
}
