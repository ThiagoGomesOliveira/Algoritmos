using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeEstiverChovendo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Se hoje estiver chovendo ?..... 1:Sim  ou  2:Não.....");
            var res = Console.ReadLine();
            int resposta = Convert.ToInt16(res);

            var situacao = resposta == 1 ? " Vou ver um Filme." : "  Vou Caminhar.";

            Console.WriteLine(" Se hoje estiver chovendo " + situacao);
            Console.ReadKey();

        }
    }
}
