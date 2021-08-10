using System;
using System.Globalization;

namespace Ex1ClasseAtributoMetodo
{
    class Program
    {
        static void Main(string[] args)     
        {
            Retangulo tot = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            tot.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tot.Altura  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           

            Console.WriteLine(tot.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(tot.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(tot.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
