using ProdutoComLucro.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProdutoComLucro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Nome do Produto");
            string nomeProduto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o Valor do Produto");
             var valor = Console.ReadLine();
             var valorProduto = Convert.ToInt64(valor);

            Produto produto = new Produto();
            produto.Valor = valorProduto;
           
            Console.WriteLine("O Valor do Produto "+ produto.ExecutarCalculoProduto(valorProduto));
            Console.ReadKey();

            

        }
    }
}
