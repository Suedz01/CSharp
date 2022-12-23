//Inverter um número digitado

using System;
class aula10
{
    static void Main()
    {
        bool i = true;
        int n1, j = 0, k = 0;
        int[] n2 = new int[10];

        Console.WriteLine("Insira o número que será invertido: ");
        n1 = int.Parse(Console.ReadLine());
        
        while(i == true)
        {
            if(n1 != 0)
            {
                n2[j] = n1%10;
                n1 = n1/10;
                j += 1;
            }
            else
            {
                i = false;
            }
        }

        while(k != j)   //Enquanto a condição estipulada não for comprida, o While continuará rodando;
        {
            Console.Write("{0}", n2[k]);
            k += 1;
        }
    }
}