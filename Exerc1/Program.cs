using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(5,10);

            Console.WriteLine("Insira o valor da base: ");
            retangulo.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Insira o valor da altura: ");
            retangulo.setAltura(int.Parse(Console.ReadLine()));

            retangulo.Calcular();

            Console.Clear();

            Console.WriteLine("Base: {0}", retangulo.getBase());
            Console.WriteLine("Altura: {0}", retangulo.getAltura());
            Console.WriteLine("Area: {0}", retangulo.getArea());

        }
    }
}
