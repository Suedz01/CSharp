using System;
class aula19
{
    public class Monstro   
    {
        public int vida;
        public int speed;
        public int armadura;
        public int ataque;
        public Monstro()
        {
            vida = 32;
            speed = 32;
            armadura = 3;
            ataque = 5;
        }
    }

    public class Heroi
    {
        public int vida;
        public int speed;
        public int armadura;
        public int ataque;
        public Heroi()
        {
            vida = 100;
            speed = 30;
            armadura = 3;
            ataque = 7;
        }
        ~Heroi()
        {
            Console.WriteLine("O heroi sucumbe...");
        }
    }

    static void Main()
    {
        Heroi a = new Heroi();
        Monstro b = new Monstro();

        while(a.vida<=0 | b.vida<=0)
        {
            if(a.speed >= b.speed)
            {
                Console.WriteLine("O herói faz o primeiro golpe");
            }
            else
            {
                Console.WriteLine("O Monstro faz o primeiro Golpe!");
                a.vida=0;
            }
        }
        Console.WriteLine(a.vida);  //PRECISO APRENDER A CRIAR FUNÇÕES DENTRO DESSES OBJETOS, COMO PERDER VIDA;
    }
}