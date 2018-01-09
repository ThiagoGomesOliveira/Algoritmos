using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número do codigo da peça");
            var numero = Console.ReadLine();

            Console.WriteLine("Digite o valor da peça");
            var valor = Console.ReadLine();

            Console.WriteLine("Quantidade de peças");
            var qtd = Console.ReadLine();

            Console.WriteLine("Calculo do valor total da peça ");
            int quantidade = Convert.ToInt32(qtd);
            int valorQtd = Convert.ToInt32(valor);
            var total = quantidade * valorQtd;

            Console.WriteLine("Valor total da peça "+ total);

            Console.ReadKey();





        }
    }
}
