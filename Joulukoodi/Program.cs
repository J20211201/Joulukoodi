using System;

namespace Joulukoodi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tehtavat tehtavat = new Tehtavat();
            int[] teht1 = { 100, 200, 100,100 };

            var tulos = tehtavat.Tehtava1(teht1);
            Console.WriteLine("Hello World!");
        }
    }
}
