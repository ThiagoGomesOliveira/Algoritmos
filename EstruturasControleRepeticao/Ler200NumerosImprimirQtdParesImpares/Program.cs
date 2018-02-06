using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ler200NumerosImprimirQtdParesImpares

{
    class Program
    {
        static void Main(string[] args)
        {
            int numPar =0;
            int numImp =0;

            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                     numPar ++;
                }
                else if(i % 2==1 )
                {
                    numImp++;
                }
                 
            }
            Console.WriteLine("0 a 200 ");
            Console.WriteLine("Quantidade de números Pares "+ numPar);
            Console.WriteLine("Quantidade de números Impares" + numImp);
            Console.ReadKey();
        }
    }
}