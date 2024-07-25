using System;
using System.Globalization;

namespace ProdutoCaixa
{

    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome 
                + ", $ "
                + Preco.ToString("F2", CI)
                +", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}
