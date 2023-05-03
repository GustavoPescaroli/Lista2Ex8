using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                double l1;
                double l2;
                double l3;
                double h1;
                double h2;
                double h3;

                Console.Write("insira o valor da primeira lateral: ");
                l1 = double.Parse(Console.ReadLine());

                Console.Write("insira o valor da Segunda lateral: ");
                l2 = double.Parse(Console.ReadLine());

                Console.Write("insira o valor da Terceira lateral: ");
                l3 = double.Parse(Console.ReadLine());

                h1 = Math.Sqrt(Math.Pow(l2, 2) + Math.Pow(l3, 2));
                h2 = Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l3, 2));
                h3 = Math.Sqrt(Math.Pow(l1, 2) + Math.Pow(l2, 2));

                if ((h1 == l1) || (h2 == l2) || (h3 == l3))
                    Console.WriteLine("os valores atribuídos para os lados formam um triângulo retângulo.");

                else
                    Console.WriteLine("os valores atribuídos para os lados não formam um triângulo retângulo");
            }
        }
    }

}