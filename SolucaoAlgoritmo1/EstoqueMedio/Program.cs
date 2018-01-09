using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da peça");
            var num = Console.ReadLine();

            Console.WriteLine("Digite a quantidade minima de estoque para a peça");
            var min = Console.ReadLine();

            Console.WriteLine("Digite a quantidade maxima do estoque para a peça");
            var max = Console.ReadLine();

            int minQtd = Convert.ToInt32(min);
            int maxQtd = Convert.ToInt32(max);

            double media = (minQtd + maxQtd) / 2;

            Console.WriteLine("Media estoque da peça " + num +" : "+media);

            Console.ReadKey();

            








        }
    }
}
