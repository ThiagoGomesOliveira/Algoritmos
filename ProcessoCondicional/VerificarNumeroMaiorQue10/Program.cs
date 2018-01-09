using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNumeroMaiorQue10
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Faça um algoritmo que leia um número e verefique se ele é maior do que 10.
        //    Se for o algoritmo deve somar mais 10 as esse número.

            Console.WriteLine("Digite um número");
            var numero = Console.ReadLine();

            int num = Convert.ToInt16(numero);

            int total = num>10 ? num+10 :num;

            Console.WriteLine("Total "+ total);
           
        }
    }
}
