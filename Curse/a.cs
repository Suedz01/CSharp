using System;

namespace Curse
{
    public class a
    {
        static void Main()
        {
            string txt = "aaa", txt2;
            txt2 = "bla bla bla x{0}{1}";
            Console.WriteLine(txt+txt2);
            txt = txt + txt2;
            Console.WriteLine(txt);
        }
    }
}