using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaNumerosParesENegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int numImpares= 0;
            for (int i = 0; i <= 20; i++)
            {
                if (i%2==0)
                {
                    soma += i;
                }
                else if (i%2==1)
                {
                    numImpares++;
                }
            }
            Console.WriteLine("0 a 20");
            Console.WriteLine("Soma dos Números Pares " +soma);
            Console.WriteLine("Quantidade de números Impares " +numImpares);
            Console.ReadKey();
        }
    }
}
