using System;
using System.Collections.Generic;

class Pilha
{
    private List<string> elementosPadrao;
    private List<string> elementos;
    private int pecaQuebrada;
    public Pilha()
    {
        elementos = new List<string> { "ventilador de teto", "suporte", "helice", "lampada", "cupula de vidro" };
        elementosPadrao = new List<string> { "ventilador de teto", "suporte", "helice", "lampada", "cupula de vidro" };
        pecaQuebrada = -1;
    }
    public void ventiladorQuebrado() //Inicializa com um item QUEBRADO
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(5); // Gera um número aleatório entre 0 e 4

        if(numeroAleatorio == 0)
        {
            elementos[numeroAleatorio] = "ventilador de teto QUEBRADO";
        }else if(numeroAleatorio == 1)
        {
            elementos[numeroAleatorio] = "suporte QUEBRADO";
        }
        else if( numeroAleatorio == 2)
        {
            elementos[numeroAleatorio] = "helice QUEBRADA";
        }
        else if (numeroAleatorio == 3)
        {
            elementos[numeroAleatorio] = "lampada QUEBRADA";
        } else
        {
            elementos[numeroAleatorio] = "cupula de vidro QUEBRADA";
        }

        pecaQuebrada = numeroAleatorio;
    }
    public void mostrarPilha()
    {
        Console.WriteLine("\n------\npilha: elementos\n");
        foreach (string elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
        Console.WriteLine("\n\n");

    }
    void Pop()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("A pilha está vazia");
        }
        string elementoRemovido = elementos[elementos.Count - 1];
        Console.WriteLine("Elemento Excluído: {0}", elementoRemovido);
        elementos.RemoveAt(elementos.Count - 1);    //descarte do topo da pilha
    }
    void Push(string elemento)
    {
        Console.WriteLine("Elemento Adicionado: {0}",elemento);

        elementos.Add(elemento);    //acrescenta um item no topo da pilha
    }
    public void fixPilha()
    {
        int j = 0;

        // identificar qual peça está quebrada
        for ( int i = elementos.Count-1; i >= 0 ; i-- )
        {
            if (i == pecaQuebrada)
            {
                Console.WriteLine("Encontrei a peça quebrada {0}", i);
                Pop();
                Push(elementosPadrao[i]);

                break;
            }
            else
            {
                Console.WriteLine("Nada de Errado {0}", i);
                Pop();
                j++;
                Console.WriteLine("\n");

            }
        }
        while (j != 0)
        {
            int k = 5 - j;
            Console.WriteLine("\nPreenchendo a Pilha: {0}", k);
            Push(elementosPadrao[k]);
            Console.WriteLine("\n");
            j--;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pilha pilha = new Pilha();

        pilha.ventiladorQuebrado();
        pilha.mostrarPilha();
        pilha.fixPilha();
        pilha.mostrarPilha();
    }
}
