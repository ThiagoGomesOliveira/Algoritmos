using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeIdade20Pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o Nome");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite o Sexo");
                var sexo = Console.ReadLine();
                Console.WriteLine("Digite idade");
                var idade = Convert.ToInt64(Console.ReadLine());

                if (sexo.Equals("m")&& idade >21)
                {
                    Console.WriteLine(nome);
                    Console.ReadKey();
                    continue;
                }
            }

        }
    }
}
