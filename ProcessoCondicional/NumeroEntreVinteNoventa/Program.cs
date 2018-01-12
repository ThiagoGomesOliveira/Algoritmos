using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroEntreVinteNoventa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um Valor");
            var num = Convert.ToInt16(Console.ReadLine());
            NumeroEntreVinteENoventa(num);

        }

        public static void NumeroEntreVinteENoventa(int num)
        {
            if (num >=20 && num<=90)
            {
                Console.WriteLine("Número está entre 20 e 90");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Número não está entre 20 e 90");
                Console.ReadKey();
            }
        }
    }
}
