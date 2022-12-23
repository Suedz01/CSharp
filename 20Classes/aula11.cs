using System;
class aula11
{
    static void Main()
    {
        int[,] matriz = new int[4,3];   //Declaração de uma matriz
        int[,] matrix = new int[3,2]{{1,3},{2,7},{5,9}};
        /*  1   3
            2   7
            5   9   */  //matriz gerada de 'matrix'
        matriz[1,2] = 12;

        Console.WriteLine(matrix[1,2]);
        Console.WriteLine(matrix[3,1]);

        Console.WriteLine(matriz[1,2]);
    }
}