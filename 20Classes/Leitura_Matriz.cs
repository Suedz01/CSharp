using System;
class aula12
{
    static void Main()
    {
        int[,] matriz = new int[5, 4];

        int rowLength = matriz.GetLength(0);    //"0" se refere as linhas
        int colLength = matriz.GetLength(1);    //"1" se refere as colunas

        
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write("Insira o valor da linha [{0}] e da coluna [{1}]: ", i+1, j+1);
                matriz[i,j]= int.Parse(Console.ReadLine());
            }
            Console.Write("\n");
        }

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", matriz[i, j]));
            }
            Console.Write("\n");
        }
        Console.ReadLine();
    }
}