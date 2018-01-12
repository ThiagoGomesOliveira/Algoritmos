using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioDescontos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salario");
            var salario = Convert.ToDouble(Console.ReadLine());

           
                double imposto = CalculoImpostoSalario(salario);
                Console.WriteLine("Imposto a pagar :" + imposto);
                Console.ReadKey();
           
           
        }

        public static double CalculoImpostoSalario(double salario)
        {
            double calculo = 0;
            if (salario > 2000)
            {
                calculo = salario * 0.3;
                return calculo;
            }
            else if (salario <= 2000 && salario >1200)
            {
                calculo = salario * 0.25;
                return calculo;
            }
            else if(salario <= 1200 && salario >600 )
            {
                calculo = salario * 0.2;
                return calculo;
            }
            else
            {
                return calculo;
            }
          }
    }
}
