using System;
class aula07
{
    enum DiasdaSemana{dom, seg, ter, qua, qui, sex, sab};
    
    static void Main()
    {
        DiasdaSemana dia = DiasdaSemana.dom; //Pesquisa no Enum por valor - valor
        Console.WriteLine(dia);
        
        DiasdaSemana ds = (DiasdaSemana)3;  //Pesquisa no Enum por índice - valor
        Console.WriteLine(ds);

        int ind = (int)DiasdaSemana.sex; //Pesquisa no enum por valor - índice
        Console.WriteLine(ind);

        int x = 26;
        char y = (char)x;
        Console.WriteLine(y);
    }
}