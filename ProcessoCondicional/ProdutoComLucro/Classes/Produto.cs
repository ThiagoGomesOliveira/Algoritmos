using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoComLucro.Classes
{
    public class Produto
    {
        public long Valor { get; set; }
        public string Nome { get; set; }

        //public Produto(long valor , string nome)
        //{
        //    this.Valor = valor;
        //    this.Nome = nome;
        //}

        private double CalcularLucroProduto(long valor)
        {
            //teste
            if (valor < 20)
            {
              var produtoPorcentagem = PorcentagemProdutoCinquentaPorCento();
                return produtoPorcentagem;
            }
            var produtoPorc = PorcentagemProdutoTrintaECincoPorcento();
            return produtoPorc;

        }

        public double PorcentagemProdutoCinquentaPorCento()
        {
            
            var porcentagem  = this.Valor * 0.5;
            return porcentagem + this.Valor;
        }
        public double PorcentagemProdutoTrintaECincoPorcento()
        {
            double produto = this.Valor * 0.35;
            return produto + this.Valor;
        }
        public double ExecutarCalculoProduto(long valor)
        {
            var  produtoReajuste =  CalcularLucroProduto(valor);
            return produtoReajuste;
        }

    }
}
