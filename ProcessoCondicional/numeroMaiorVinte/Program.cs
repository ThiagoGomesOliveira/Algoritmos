using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroMaiorVinte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            var numero = Console.ReadLine();
            int num = Convert.ToInt32(numero.ToString());
            MaiorQueVinte(num);
        }
        public static void MaiorQueVinte(int num)
        {

            if (num > 20 )
            {
                Console.WriteLine("Número Digitado maior que 20: "+num);
                Console.ReadKey();
            }
            else if(num ==20)
            {
                Console.WriteLine("Número Digitado é 20 " );
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Número Digitado menor que 20 : " + num);
                Console.ReadKey();
            }

        }
    }
}
